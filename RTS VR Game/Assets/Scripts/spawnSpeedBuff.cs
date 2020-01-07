using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSpeedBuff : MonoBehaviour
{
    public GameObject speedPrefab;
    public GameObject otherButton1;
    public GameObject otherButton2;
    public GameObject thisButton;

    public void instantiateSpeedBuff()
    {
        Instantiate(speedPrefab);
        otherButton1.SetActive(false);
        otherButton2.SetActive(false);
        thisButton.SetActive(false);
    }
}
