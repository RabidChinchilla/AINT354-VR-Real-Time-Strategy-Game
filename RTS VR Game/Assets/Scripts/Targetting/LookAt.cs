using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{

    private Transform target;
    private GameObject targetObject;
    private int damage;
    private float currentHitDistance;


    // Start is called before the first frame update
    void Awake()
    {
        damage = gameObject.GetComponent<unitAttributes>().damage;
    }

    void Update()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.SphereCast(transform.position, 5f, transform.forward, out hit, 20))
        {
            currentHitDistance = hit.distance;
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Look at Did Hit");
        }
        else
        {
            currentHitDistance = hit.distance;
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 70, Color.white);
            Debug.Log("Look at Did not Hit");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NonplayerUnit")
        {
            target = other.transform;
            targetObject = other.gameObject;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "NonplayerUnit")
        {
            target = other.transform;
            targetObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "NonplayerUnit")
        {
            target = null;
            targetObject = null;
        }
    }

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(Attack());
    }
    IEnumerator Attack()
    {
        if (target != null)
        {
            Debug.Log(damage);
            transform.LookAt(target);
            targetObject.GetComponent<unitAttributes>().TakeDamage(damage);
        }
        damage = 2;
        yield return new WaitForSecondsRealtime(1.5f);
        StartCoroutine(Attack());
        //Debug.Log("Damage is: "+damage);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Debug.DrawLine(transform.position, transform.position + transform.forward * currentHitDistance);
        Gizmos.DrawWireSphere(transform.position + transform.forward * currentHitDistance, 5f);
    }
}
