using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factoryController : MonoBehaviour
{
    public GameObject commandHub;

    // Start is called before the first frame update
    void Awake()
    {
        commandHub = GameObject.Find("CommandBuilding");
    }

    // Update is called once per frame
    void Update()
    {
        commandPost player = commandHub.GetComponent<commandPost>();
        Wait();
        player.resources += 10;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Wait is OVer");
    }
}
