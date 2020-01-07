using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnLargeBomb : MonoBehaviour
{
    public GameObject LargeBombPrefab;
    public GameObject otherButton1;
    public GameObject otherButton2;
    public GameObject thisButton;

    public void instantiateLargeBomb()
    {
        Instantiate(LargeBombPrefab);
        otherButton1.SetActive(false);
        otherButton2.SetActive(false);
        thisButton.SetActive(false);
    }
}
