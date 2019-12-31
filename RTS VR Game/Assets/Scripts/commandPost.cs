using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using NUnit.Framework;

public class commandPost : MonoBehaviour
{
    public int health = 2000;
    public int resources;
    public Text resourceCounter;

    //void OnEnable()
    //{
    //    Assert.IsNotNull(resources, "ScoreText is not set!");
    //    Assert.IsNotNull(resourceCounter, "ScoreText is not set!");
    //}

    // Start is called before the first frame update
    void Start()
    {
        resources = 200;
        resourceCounter.text = "Resources: " + resources;
    }

    // Update is called once per frame
    void Update()
    {
        resourceCounter.text = "Resources: " + resources;
    }
}
