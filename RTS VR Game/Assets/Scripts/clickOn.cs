using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickOn : MonoBehaviour
{
    //used for objects that can be selected
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
        Camera.main.gameObject.GetComponent<click>().selectableObjects.Add(this.gameObject);
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
