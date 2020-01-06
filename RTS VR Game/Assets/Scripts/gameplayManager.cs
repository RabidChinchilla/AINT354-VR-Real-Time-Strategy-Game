using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameplayManager : MonoBehaviour
{
    //Buttons for the Menu

    //Command Hub Options
    public Button cMain;
    public Button cOption1;
    public Button cOption2;
    public Button cOption3;

    //Info Option

    public Button iMain;
    public Button iOption1;
    public Button iOption2;
    public Button iOption3;

    //Barracks Option
    public Button bMain;
    public Button bOption1;
    public Button bOption2;
    public Button bOption3;

    //Commander Abilities
    public Button aMain;
    public Button aOption1;
    public Button aOption2;
    public Button aOption3;
    private bool aMenuOpen = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnClickCommandButton()
    {
        cOption1.enabled = true;
        cOption2.enabled = true;
        cOption3.enabled = true;
    }

    void OnClickBarracksButton()
    {
        bOption1.enabled = true;
        bOption2.enabled = true;
        bOption3.enabled = true;
    }

    void OnClickInfoButton()
    {
        iOption1.enabled = true;
        iOption2.enabled = true;
        iOption3.enabled = true;
    }

    void OnClickAbilitiesButton()
    {
        if (aMenuOpen != true)
        {
            aOption1.enabled = true;
            aOption2.enabled = true;
            aOption3.enabled = true;
            aMenuOpen = true;
        }
        if (aMenuOpen != false)
        {
            aOption1.enabled = false;
            aOption2.enabled = false;
            aOption3.enabled = false;
            aMenuOpen = false;
        }

    }

    void OnClickCommandMain()
    {
        cMain.enabled = true;
        iMain.enabled = false;
        bMain.enabled = false;
    }
    void OnClickCInfoMain()
    {
        cMain.enabled = false;
        iMain.enabled = true;
        bMain.enabled = false;
    }
    void OnClickBarracksMain()
    {
        cMain.enabled = false;
        iMain.enabled = false;
        bMain.enabled = true;
    }
}
