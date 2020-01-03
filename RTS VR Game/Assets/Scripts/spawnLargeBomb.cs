using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnLargeBomb : MonoBehaviour
{
    public GameObject LargeBombPrefab;

    public void instantiateLargeBomb()
    {
        Instantiate(LargeBombPrefab);
    }
}
