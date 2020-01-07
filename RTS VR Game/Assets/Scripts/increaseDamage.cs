using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseDamage : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something in trigger");
        if (other.gameObject.CompareTag("SelectableUnit"))
        {
            Debug.Log("Hit friendly");
            other.gameObject.SendMessage("Increase Damage");
            Destroy(gameObject);
        }
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Something in trigger");
        if (other.gameObject.CompareTag("SelectableUnit"))
        {
            Debug.Log("Hit friendly");
            other.gameObject.SendMessage("Increase Damage");
            Destroy(gameObject);
        }
    }
}
