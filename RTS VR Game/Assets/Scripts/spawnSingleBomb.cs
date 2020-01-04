using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSingleBomb : MonoBehaviour
{
    public GameObject singleBombPrefab;
    public GameObject otherButton1;
    public GameObject otherButton2;
    public GameObject thisButton;

    public void instantiateSingleBomb()
    {
        Instantiate(singleBombPrefab);
        otherButton1.SetActive(false);
        otherButton2.SetActive(false);
        thisButton.SetActive(false);
    }
}
