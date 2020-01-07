using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showCommanderAbilities : MonoBehaviour
{
    public GameObject artilery1;
    public GameObject artilery2;
    public GameObject artilery3;
    public GameObject scout1;
    public GameObject scout2;
    public GameObject scout3;
    public GameObject suppourt1;
    public GameObject suppourt2;
    public GameObject suppourt3;

    public bool buttonsActive = false;

    public void showAbilityButtons()
    {
        Debug.Log("Show Abilities");
        if (buttonsActive == false){
            artilery1.SetActive(true);
            artilery2.SetActive(true);
            artilery3.SetActive(true);

            scout1.SetActive(true);
            scout2.SetActive(true);
            scout3.SetActive(true);

            suppourt1.SetActive(true);
            suppourt2.SetActive(true);
            suppourt3.SetActive(true);

            buttonsActive = true;
        }
        else
        {
            artilery1.SetActive(false);
            artilery2.SetActive(false);
            artilery3.SetActive(false);

            scout1.SetActive(false);
            scout2.SetActive(false);
            scout3.SetActive(false);

            suppourt1.SetActive(false);
            suppourt2.SetActive(false);
            suppourt3.SetActive(false);

            buttonsActive = false;

        }


    }
}
