using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class priceCheck : MonoBehaviour
{
    public int cost;

    private GameObject commandHub;

    private GameObject info;

    private Text infoText;
    // Start is called before the first frame update
    void Start()
    {
        commandHub = GameObject.Find("Player Hub");
        info = GameObject.FindGameObjectWithTag("Funds");

        infoText = info.GetComponent<Text>();


        if (commandHub.GetComponent<commandPost>().resources > cost)
        {
            commandHub.GetComponent<commandPost>().resources -= cost;
        }
        if (commandHub.GetComponent<commandPost>().resources < cost)
        {
            StartCoroutine(LackofFunds());
        }

    }


    IEnumerator LackofFunds()
    {

        infoText.text = "Insufficient Funds";
        yield return new WaitForSecondsRealtime(0.5f);
        Destroy(gameObject);
    }
}
