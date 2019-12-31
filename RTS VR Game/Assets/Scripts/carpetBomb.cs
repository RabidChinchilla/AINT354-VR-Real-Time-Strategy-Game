using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class carpetBomb : MonoBehaviour
{
    public Camera camera;

    void Start()
    {

    }

        void Update()
    {

        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        // Does the ray intersect any objects excluding the layer
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, 1 << LayerMask.NameToLayer("GroundLayer")))
        {
            //Debug.DrawRay(ray * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
        else
        {
            //Debug.DrawRay(ray * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }


}
