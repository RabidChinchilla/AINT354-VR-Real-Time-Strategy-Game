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
            cost = 200;
        }
        if (unit == "Tank")
        {
            cost = 200;
        }
        if (unit == "Vulcan")
        {
            cost = 200;
        }
        if (unit == "Barracks")
        {
            cost = 200;
        }
        if (unit == "Info")
        {
            cost = 200;
        }
        if (unit == "Factory")
        {
            cost = 200;
        }
        if (unit == "Ability1")
        {
            cost = 200;
        }
        if (unit == "Ability2")
        {
            cost = 200;
        }
        if (unit == "Ability3")
        {
            cost = 200;
        }
        if (unit == "Upgrade")
        {
            cost = 200;
        }
        if (unit == "Upgrade")
        {
            cost = 200;
        }
        if (unit == "Upgrade")
        {
            cost = 200;
        }
        return cost;
    }

    float GetTime(string unit)
    {
        if (unit == "Humvee")
        {
            time = 10f;
        }
        if (unit == "Tank")
        {
            time = 10f;
        }
        if (unit == "Vulcan")
        {
            time = 10f;
        }
        if (unit == "Barracks")
        {
            time = 10f;
        }
        if (unit == "Info")
        {
            time = 10f;
        }
        if (unit == "Factory")
        {
            time = 10f;
        }
        if (unit == "Ability1")
        {
            time = 10f;
        }
        if (unit == "Ability2")
        {
            time = 10f;
        }
        if (unit == "Ability3")
        {
            time = 10f;
        }
        if (unit == "Upgrade")
        {
            time = 10f;
        }
        if (unit == "Upgrade")
        {
            time = 10f;
        }
        if (unit == "Upgrade")
        {
            time = 10f;
        }
        return time;
    }
}
