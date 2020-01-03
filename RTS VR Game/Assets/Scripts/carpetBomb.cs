using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpetBomb : MonoBehaviour
{

    public GameObject carpetBombSet;
    public GameObject spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 20);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(carpetBombSet, spawnPoint.transform.position, spawnPoint.transform.rotation);
            Debug.Log("Drop Bombs");
        }
    }
}
