using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScout : MonoBehaviour
{
    public GameObject scoutPrefab;
    public GameObject otherButton1;
    public GameObject otherButton2;
    public GameObject thisButton;

    public void instantiateScout()
    {
        Instantiate(scoutPrefab);
        otherButton1.SetActive(false);
        otherButton2.SetActive(false);
        thisButton.SetActive(false);
    }
}
