using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBuildings : MonoBehaviour
{

    private bool visible = false;
    [Tooltip("References to buttons of the build panel")]
    public GameObject[] buttons;
    [Tooltip("Build prefabs from Prefabs/BuildableUnits/")]
    public GameObject[] prefabs;

    public void showButtons()
    {
        if(visible == false)
        {
            //foreach (GameObject button in buttons)
            //{
            //    button.setActive(true);
            //}
        }
        else
        {
            //foreach (GameObject button in buttons)
            //{
            //    button.setActive(false);
            //}
        }
    }
}
