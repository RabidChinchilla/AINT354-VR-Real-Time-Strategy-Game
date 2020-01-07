using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showBuildingButtons : MonoBehaviour
{
    public GameObject button1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Debug.Log("Unit clicked: " + hit.transform.gameObject.name);
                if (hit.transform.gameObject.tag == "CommandBuilding")
                {
                    button1.SetActive(true);
                    return;
                }
            }

        }

    }
}
