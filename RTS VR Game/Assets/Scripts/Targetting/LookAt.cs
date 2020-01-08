using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{

    private Transform target;
    private GameObject targetObject;
    private int damage;


    // Start is called before the first frame update
    void Awake()
    {
        damage = gameObject.GetComponent<unitAttributes>().damage;
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
}
