using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turnInfoOff : MonoBehaviour
{
    private bool active;
    private Text infoText;
    // Start is called before the first frame update
    void Start()
    {
        infoText = gameObject.GetComponent<Text>();
        infoText.text = "";
        StartCoroutine(TurnOff());

    }

    // Update is called once per frame
    IEnumerator TurnOff()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        infoText.text = "";
        Debug.Log("Turned Off");

        StartCoroutine(TurnOff());
    }
}
