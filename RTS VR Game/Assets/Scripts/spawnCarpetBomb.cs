using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCarpetBomb : MonoBehaviour
{

    public GameObject carpetBombPrefab;
    public GameObject otherButton1;
    public GameObject otherButton2;
    public GameObject thisButton;

    public void instantiateCarpetBomb()
    {
        Instantiate(carpetBombPrefab);
        otherButton1.SetActive(false);
        otherButton2.SetActive(false);
        thisButton.SetActive(false);
    }
}
