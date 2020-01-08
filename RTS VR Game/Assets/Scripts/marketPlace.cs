using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marketPlace : MonoBehaviour
{
    // This is where all the build times and prices are for each buildable object

    //Buildings
    int cost;
    float time;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetCost(string unit)
    {
        if (unit == "Humvee")
        {
            cost = 100;
        }
        if (unit == "Tank")
        {
            cost = 250;
        }
        if (unit == "Vulcan")
        {
            cost = 300;
        }
        if (unit == "Barracks")
        {
            cost = 400;
        }
        if (unit == "Info")
        {
            cost = 300;
        }
        if (unit == "Factory")
        {
            cost = 600;
        }
        if (unit == "Ability1")
        {
            cost = 250;
        }
        if (unit == "Ability2")
        {
            cost = 300;
        }
        if (unit == "Ability3")
        {
            cost = 600;
        }
        if (unit == "UpgradeHealth")
        {
            cost = 200;
        }
        if (unit == "UpgradeDamage")
        {
            cost = 200;
        }
        return cost;
    }

}
