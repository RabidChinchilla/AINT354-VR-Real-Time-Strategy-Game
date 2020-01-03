using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSingleBomb : MonoBehaviour
{
    public GameObject singleBombPrefab;

    public void instantiateSingleBomb()
    {
        Instantiate(singleBombPrefab);
    }
}
