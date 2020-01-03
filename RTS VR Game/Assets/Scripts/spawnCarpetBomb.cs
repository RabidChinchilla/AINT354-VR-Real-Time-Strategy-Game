using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCarpetBomb : MonoBehaviour
{

    public GameObject carpetBombPrefab;

    public void instantiateCarpetBomb()
    {
        Instantiate(carpetBombPrefab);
    }
}
