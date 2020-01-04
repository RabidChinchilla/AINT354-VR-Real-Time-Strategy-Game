using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnDamageBuff : MonoBehaviour
{
    public GameObject damagePrefab;
    public GameObject otherButton1;
    public GameObject otherButton2;
    public GameObject thisButton;

    public void instantiateDamageBuff()
    {
        Instantiate(damagePrefab);
        otherButton1.SetActive(false);
        otherButton2.SetActive(false);
        thisButton.SetActive(false);
    }
}
