using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    [SerializeField]
    private LayerMask clickablesLayer;

    private List<GameObject> selectedObjects;

    void Start()
    {
        selectedObjects = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            //deselect everything after right click
            if (selectedObjects.Count > 0)
            {
                foreach (GameObject obj in selectedObjects)
                {
                    obj.GetComponent<clickOn>().currentlySelected = false;
                    obj.GetComponent<clickOn>().clickMe();
                }

                selectedObjects.Clear();
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit rayHit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, clickablesLayer))
            {
                clickOn clickOnScript = rayHit.collider.GetComponent<clickOn>();

                if (Input.GetKey("left ctrl"))
                {
                    if(clickOnScript.currentlySelected == false)
                    {
                        selectedObjects.Add(rayHit.collider.gameObject);
                        clickOnScript.currentlySelected = true;
                        clickOnScript.clickMe();

                    }
                    else
                    {
                        selectedObjects.Remove(rayHit.collider.gameObject);
                        clickOnScript.currentlySelected = false;
                        clickOnScript.clickMe();
                    }
                }
                else
                {
                    //select one object and deselect all others
                    if(selectedObjects.Count > 0)
                    {
                        foreach(GameObject obj in selectedObjects)
                        {
                            obj.GetComponent<clickOn>().currentlySelected = false;
                            obj.GetComponent<clickOn>().clickMe();
                        }

                        selectedObjects.Clear();
                    }

                    selectedObjects.Add(rayHit.collider.gameObject);
                    clickOnScript.currentlySelected = true;
                    clickOnScript.clickMe();
                }
            }
        }
    }
}
