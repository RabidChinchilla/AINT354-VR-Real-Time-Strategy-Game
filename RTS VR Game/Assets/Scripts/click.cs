using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    [SerializeField]
    private LayerMask clickablesLayer;

    private List<GameObject> selectedObjects;

    [HideInInspector]
    public List<GameObject> selectableObjects;

    private Vector3 mousePos1;
    private Vector3 mousePos2;

    void Awake()
    {
        selectedObjects = new List<GameObject>();
        selectableObjects = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            clearSelection();
        }

        if (Input.GetMouseButtonDown(0))
        {
            mousePos1 = Camera.main.ScreenToViewportPoint(Input.mousePosition);

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
                    clearSelection();

                    selectedObjects.Add(rayHit.collider.gameObject);
                    clickOnScript.currentlySelected = true;
                    clickOnScript.clickMe();
                }
            }

            if (Input.GetMouseButtonUp(0))
            {
                mousePos2 = Camera.main.ScreenToViewportPoint(Input.mousePosition);

                if (mousePos1 != mousePos2)
                {
                    selectObjects();
                }
            }
        }
    }

    void selectObjects()
    {
        List<GameObject> removeObjects = new List<GameObject>();

        if (Input.GetKey("left ctrl") == false)
        {
            clearSelection();
        }

        Rect selectRect = new Rect(mousePos1.x, mousePos1.y, mousePos2.x - mousePos1.x, mousePos2.y - mousePos1.y);

        foreach (GameObject selectObj in selectableObjects)
        {
            if (selectObj != null)
            {
                if (selectRect.Contains(Camera.main.WorldToViewportPoint(selectObj.transform.position), true))
                {
                    selectedObjects.Add(selectObj);
                    selectObj.GetComponent<clickOn>().currentlySelected = true;
                    selectObj.GetComponent<clickOn>().clickMe();
                }
            }
            else
            {
                removeObjects.Add(selectObj);
            }
        }

        if (removeObjects.Count > 0)
        {
            foreach (GameObject remove in removeObjects)
            {
                selectableObjects.Remove(remove);
            }

            removeObjects.Clear();
        }
    }

    void clearSelection()
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
}
