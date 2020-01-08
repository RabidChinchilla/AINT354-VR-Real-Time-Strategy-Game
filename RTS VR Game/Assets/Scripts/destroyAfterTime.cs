using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAfterTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame


    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(10);
        Debug.Log("destroying UAV");
        Destroy(gameObject);
    }
}
