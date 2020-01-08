using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factoryController : MonoBehaviour
{
    public GameObject commandHub;

    // Start is called before the first frame update
    void Awake()
    {
        commandHub = GameObject.Find("Player Hub");
        StartCoroutine(Wait());
    }


    IEnumerator Wait()
    {
        commandPost player = commandHub.GetComponent<commandPost>();
        yield return new WaitForSecondsRealtime(3);
        StartCoroutine(Wait());
        Debug.Log("Wait is OVer");
        player.resources += 20;
    }
}
