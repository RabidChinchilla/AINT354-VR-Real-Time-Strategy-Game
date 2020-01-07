using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnUnits : MonoBehaviour
{
    public GameObject tank;
    public GameObject humvee;
    public GameObject vulcan;

    public GameObject spawnPoint;
    public int resources;
    public marketPlace marketPlace;


    void Update()
    {
        spawnPoint = GameObject.FindGameObjectWithTag("Spawn");
        resources = GameObject.FindGameObjectWithTag("CommandBuilding").GetComponent<commandPost>().resources;
        marketPlace = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<marketPlace>();
    }

    public void spawnTank()
    {
        int cost = marketPlace.GetCost("Tank");
        if (resources > cost)
        {
            Instantiate(tank, spawnPoint.transform.position, spawnPoint.transform.rotation);
            GameObject.FindGameObjectWithTag("CommandBuilding").GetComponent<commandPost>().resources -= cost;
        }
        
    }

    public void spawnHumvee()
    {
        int cost = marketPlace.GetCost("Humvee");
        if (resources > cost)
        {
            Instantiate(humvee, spawnPoint.transform.position, spawnPoint.transform.rotation);
            GameObject.FindGameObjectWithTag("CommandBuilding").GetComponent<commandPost>().resources -= cost;
        }

    }

    public void spawnVulcan()
    {
        int cost = marketPlace.GetCost("Vulcan");
        if (resources > cost)
        {
            Instantiate(vulcan, spawnPoint.transform.position, spawnPoint.transform.rotation);
            GameObject.FindGameObjectWithTag("CommandBuilding").GetComponent<commandPost>().resources -= cost;
        }

    }

}
