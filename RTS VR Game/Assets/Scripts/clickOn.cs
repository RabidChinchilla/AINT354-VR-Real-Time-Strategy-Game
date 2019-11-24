using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickOn : MonoBehaviour
{
    [SerializeField]
    private Material purple;
    [SerializeField]
    private Material green;

    private MeshRenderer myRend;

    [HideInInspector]
    public bool currentlySelected = false;

    // Start is called before the first frame update
    void Start()
    {
        myRend = GetComponent<MeshRenderer>();
        clickMe();
    }

    public void clickMe()
    {
        if (currentlySelected == false)
        {
            myRend.material = purple;
        }
        else
        {
            myRend.material = green;
        }
    }
}
