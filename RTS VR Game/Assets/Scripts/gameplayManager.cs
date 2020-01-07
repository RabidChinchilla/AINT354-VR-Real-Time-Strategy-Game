using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameplayManager : MonoBehaviour
{
    //Buttons for the Menu

    //Command Hub Options
    //public Button cMain;
    //public Button cOption1;
    //public Button cOption2;
    //public Button cOption3;
    public GameObject cMain;
    public GameObject cOption1;
    public GameObject cOption2;
    public GameObject cOption3;

    //Info Option

    public GameObject iMain;
    public GameObject iOption1;
    public GameObject iOption2;
    public GameObject iOption3;

    //Barracks Option
    public GameObject bMain;
    public GameObject bOption1;
    public GameObject bOption2;
    public GameObject bOption3;

    //Commander Abilities
    public GameObject aMain;
    public GameObject artilery1;
    public GameObject artilery2;
    public GameObject artilery3;
    private bool aMenuOpen = false;

    private bool alreadyActive = false;

    // Start is called before the first frame update
    void Start()
    {
        //OnClickCommandButton();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Debug.Log("HIT: " + hit.transform.gameObject.name);
                Debug.Log("HIT: " + hit.transform.gameObject.tag);
                if (hit.transform.gameObject.tag == "CommandBuilding")
                {
                    //Debug.Log(alreadyActive + " before method");
                    OnClickCommandButton();
                    //Debug.Log(alreadyActive + " after method");
                    //Debug.Log("Command Hub Hit");
                    //if (alreadyActive == false)
                    //{
                    //    cOption1.enabled = true;
                    //    cOption2.enabled = true;
                    //    cOption3.enabled = true; ;
                    //    alreadyActive = true;
                    //    Debug.Log("Button Opened");
                    //}
                    //else
                    //{
                    //    cOption1.enabled = false; ;
                    //    cOption2.enabled = false; ;
                    //    cOption3.enabled = false; ;
                    //    alreadyActive = false;
                    //}
                    return;
                }

                if (hit.transform.gameObject.tag == "Barracks")
                {
                    Debug.Log("Barracks Hit");
                    if (alreadyActive == false)
                    {
                        bMain.SetActive(true);
                        bOption1.SetActive(true);
                        bOption2.SetActive(true);
                        bOption3.SetActive(true);
                        alreadyActive = true;
                    }
                    else
                    {
                        bMain.SetActive(false);
                        bOption1.SetActive(false);
                        bOption2.SetActive(false);
                        bOption3.SetActive(false);
                        alreadyActive = false;
                    }
                    return;
                }
                else if (hit.transform.gameObject.tag == "InfoBuilding")
                {
                    Debug.Log("Info Building Hit");
                    if (alreadyActive == false)
                    {
                        iMain.SetActive(true);
                        iOption1.SetActive(true);
                        iOption2.SetActive(true);
                        iOption3.SetActive(true);
                        alreadyActive = true;
                    }
                    else
                    {
                        iMain.SetActive(false);
                        iOption1.SetActive(false);
                        iOption2.SetActive(false);
                        iOption3.SetActive(false);
                        alreadyActive = false;
                    }
                    return;
                }
            }

        }
    }

    void OnClickCommandButton()
    {
        Debug.Log("Show Abilities");
        if (alreadyActive == false)
        {
            cMain.SetActive(true);
            cOption1.SetActive(true);
            cOption2.SetActive(true);
            cOption3.SetActive(true);

            alreadyActive = true;
        }
        else
        {
            cMain.SetActive(false);
            cOption1.SetActive(false);
            cOption2.SetActive(false);
            cOption3.SetActive(false);

            alreadyActive = false;

        }
    }

    //void OnClickBarracksButton()
    //{
    //    bOption1.enabled = true;
    //    bOption2.enabled = true;
    //    bOption3.enabled = true;
    //}

    //void OnClickInfoButton()
    //{
    //    iOption1.enabled = true;
    //    iOption2.enabled = true;
    //    iOption3.enabled = true;
    //}


    public void showAbilityButtons()
    {
        Debug.Log("Show Abilities");
        if (alreadyActive == false)
        {
            artilery1.SetActive(true);
            artilery2.SetActive(true);
            artilery3.SetActive(true);

            //scout1.SetActive(true);
            //scout2.SetActive(true);
            //scout3.SetActive(true);

            //suppourt1.SetActive(true);
            //suppourt2.SetActive(true);
            //suppourt3.SetActive(true);

            alreadyActive = true;
        }
        else
        {
            artilery1.SetActive(false);
            artilery2.SetActive(false);
            artilery3.SetActive(false);

            //scout1.SetActive(false);
            //scout2.SetActive(false);
            //scout3.SetActive(false);

            //suppourt1.SetActive(false);
            //suppourt2.SetActive(false);
            //suppourt3.SetActive(false);

            alreadyActive = false;

        }


    }

    //void OnClickCommandMain()
    //{
    //    cMain.enabled = true;
    //    iMain.enabled = false;
    //    bMain.enabled = false;
    //}
    //void OnClickCInfoMain()
    //{
    //    cMain.enabled = false;
    //    iMain.enabled = true;
    //    bMain.enabled = false;
    //}
    //void OnClickBarracksMain()
    //{
    //    cMain.enabled = false;
    //    iMain.enabled = false;
    //    bMain.enabled = true;
    //}
}
