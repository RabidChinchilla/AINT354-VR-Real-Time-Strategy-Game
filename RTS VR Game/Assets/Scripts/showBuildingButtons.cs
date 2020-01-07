using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showBuildingButtons : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    private bool alreadyActive = false;

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
                    if (alreadyActive == false)
                    {
                        button1.SetActive(true);
                        button2.SetActive(true);
                        button3.SetActive(true);
                        alreadyActive = true;
                    }
                    else
                    {
                        button1.SetActive(false);
                        button2.SetActive(false);
                        button3.SetActive(false);
                        alreadyActive = false;
                    }
                    return;
                }
            }

        }

    }
}
