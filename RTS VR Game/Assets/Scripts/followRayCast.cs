using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followRayCast : MonoBehaviour
{
    private Camera camera;

    void Start()
    {
        //This gets the Main Camera from the Scene
        camera = Camera.main;
    }

    void Update()
    {

        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        // Does the ray intersect any objects excluding the layer
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, 1 << LayerMask.NameToLayer("GroundLayer")))
        {
            this.transform.position = hit.point;
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.Log("Did not Hit");
        }
    }
}
