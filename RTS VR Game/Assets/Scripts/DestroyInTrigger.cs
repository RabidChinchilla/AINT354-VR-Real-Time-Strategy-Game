using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInTrigger : MonoBehaviour
{

    public int damage = 5;  

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something in trigger");
        if (other.gameObject.CompareTag("NonplayerUnit"))
        {
            Debug.Log("Hit Enemy");
            //other.gameObject.GetComponent<enemyHub>().Die();
            other.gameObject.GetComponent<enemyUnit>().TakeDamage(damage);
            Destroy(other.gameObject);
        }
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Something in trigger");
        if (other.gameObject.CompareTag("NonplayerUnit"))
        {
            Debug.Log("Hit Enemy");
            //other.gameObject.GetComponent<enemyHub>().Die();
            other.gameObject.GetComponent<enemyUnit>().TakeDamage(damage);
            Destroy(other.gameObject);
        }
    }

}
