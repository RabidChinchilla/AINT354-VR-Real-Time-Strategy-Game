using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnHealEffect : MonoBehaviour
{
    public GameObject healPrefab;
    public GameObject otherButton1;
    public GameObject otherButton2;
    public GameObject thisButton;

    public void instantiateHeal()
    {
        Instantiate(healPrefab);
        otherButton1.SetActive(false);
        otherButton2.SetActive(false);
        thisButton.SetActive(false);
    }
}
