using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLook : MonoBehaviour
{
    private Transform target;
    private GameObject targetObject;
    private int damage;


    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SelectableUnit")
        {
            target = other.transform;
            targetObject = other.gameObject;
        }
        if (other.tag == "CommanderBuilding")
        {
            target = other.transform;
            targetObject = other.gameObject;
        }
        if (other.tag == "Barracks")
        {
            target = other.transform;
            targetObject = other.gameObject;
        }
        if (other.tag == "Factory")
        {
            target = other.transform;
            targetObject = other.gameObject;
        }
        if (other.tag == "InfoBuilding")
        {
            target = other.transform;
            targetObject = other.gameObject;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "SelectableUnit")
        {
            target = other.transform;
            targetObject = other.gameObject;
        }
        if (other.tag == "CommanderBuilding")
        {
            target = other.transform;
            targetObject = other.gameObject;
        }
        if (other.tag == "Barracks")
        {
            target = other.transform;
            targetObject = other.gameObject;
        }
        if (other.tag == "Factory")
        {
            target = other.transform;
            targetObject = other.gameObject;
        }
        if (other.tag == "InfoBuilding")
        {
            target = other.transform;
            targetObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "SelectableUnit")
        {
            target = null;
            targetObject = null;
        }
        if (other.tag == "CommanderBuilding")
        {
            target = null;
            targetObject = null;
        }
        if (other.tag == "Barracks")
        {
            target = null;
            targetObject = null;
        }
        if (other.tag == "Factory")
        {
            target = null;
            targetObject = null;
        }
        if (other.tag == "InfoBuilding")
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
