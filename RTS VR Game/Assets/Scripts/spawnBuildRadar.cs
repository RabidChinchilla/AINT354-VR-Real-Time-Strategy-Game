using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBuildRadar : MonoBehaviour
{
    public GameObject RadarPrefab;
    public GameObject otherButton1;
    public GameObject otherButton2;
    public GameObject thisButton;

    public void instantiateRadar()
    {
        Instantiate(RadarPrefab);
        otherButton1.SetActive(false);
        otherButton2.SetActive(false);
        thisButton.SetActive(false);
    }
}
