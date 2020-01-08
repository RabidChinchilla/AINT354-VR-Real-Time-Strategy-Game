using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableFollowRayCast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<followRayCast>().enabled = false;
        }
    }
}
