using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class commandPost : MonoBehaviour
{
    private const string V = "$";
    private const string H = "HP";
    public int health = 2000;
    public int resources = 200;
    public Text resourceCounter;
    public Text healthCounter;

    // Start is called before the first frame update
    void Start()
    {
        resourceCounter.text = V + resources;
        healthCounter.text = health + H;
    }

    // Update is called once per frame
    void Update()
    {
        resourceCounter.text = V + resources;
        healthCounter.text = health + H;
    }
}
