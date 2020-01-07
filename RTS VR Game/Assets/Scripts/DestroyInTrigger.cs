using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something in trigger");
        if (other.gameObject.CompareTag("NonplayerUnit"))
        {
            Debug.Log("Hit Enemy");
            //Destroy(other.gameObject);
        }
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Something in trigger");
        if (other.gameObject.CompareTag("NonplayerUnit"))
        {
            Debug.Log("Hit Enemy");
            //Destroy(other.gameObject);
        }
    }

}
