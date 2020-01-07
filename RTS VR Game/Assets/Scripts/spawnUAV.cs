using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnUAV : MonoBehaviour
{
    public GameObject UAVPrefab;
    public GameObject otherButton1;
    public GameObject otherButton2;
    public GameObject thisButton;

    public void instantiateUAV()
    {
        Instantiate(UAVPrefab);
        otherButton1.SetActive(false);
        otherButton2.SetActive(false);
        thisButton.SetActive(false);
    }
}
