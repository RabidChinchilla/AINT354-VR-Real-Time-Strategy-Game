using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBuildings : MonoBehaviour
{
    public GameObject MineButton;

    public void showButtons()
    {
        if(MineButton.active == false)
        {
            MineButton.SetActive(true);
        }
        else
        {
            MineButton.SetActive(false);
        }
    }
}
