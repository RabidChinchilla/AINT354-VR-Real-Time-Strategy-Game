using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourcePool : MonoBehaviour
{
    public GameObject playerBase;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("mine"))
        {
            commandPost player = playerBase.GetComponent<commandPost>();
            player.resources += 1;
        }
    }
}
