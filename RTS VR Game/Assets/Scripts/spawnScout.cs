using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScout : MonoBehaviour
{
    private Camera camera;

    public GameObject spawn;

    public GameObject scoutPrefab;
    public GameObject otherButton1;
    public GameObject otherButton2;
    public GameObject thisButton;

    void Start()
    {
        //This gets the Main Camera from the Scene
        camera = Camera.main;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<followRayCast>().enabled = false;
        }
    }

    public void instantiateScout()
    {
        Instantiate(scoutPrefab, spawn.transform);
        otherButton1.SetActive(false);
        otherButton2.SetActive(false);
        thisButton.SetActive(false);
    }
}
