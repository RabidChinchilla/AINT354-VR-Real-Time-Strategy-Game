using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankLook : MonoBehaviour
{
    public float maxDistance = 20;
    private Transform target;
    private GameObject targetObject;
    private int damage;
    private float currentHitDistance;

    private GameObject other;


    // Start is called before the first frame update
    void Awake()
    {
        damage = gameObject.GetComponent<unitAttributes>().damage;
    }

    void Update()
    {
        RaycastHit hit;

        if (Physics.SphereCast(transform.position, 10f, transform.forward, out hit, maxDistance))
        {
            currentHitDistance = hit.distance;
            other = hit.collider.gameObject;
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if (other.tag == "NonplayerUnit")
            {
                Debug.Log("Hit " + other.name);
                target = other.transform;
                targetObject = other.gameObject;
            }
            Debug.Log("Look at Did Hit");
        }
        else
        {
            currentHitDistance = 20;
            target = null;
            targetObject = null;
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 70, Color.white);
            Debug.Log("Look at Did not Hit");
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
            targetObject.GetComponent<enemyUnit>().TakeDamage(damage);
        }
        damage = 8;
        yield return new WaitForSecondsRealtime(3f);
        StartCoroutine(Attack());
        //Debug.Log("Damage is: "+damage);
    }
}
