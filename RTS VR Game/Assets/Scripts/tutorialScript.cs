using RTS_Cam;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialScript : MonoBehaviour
{
    public AudioClip commandhubDesc;
    public Camera cameraControls;
    public AudioSource audio;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        cameraControls.GetComponent<RTS_Camera>().enabled = false;
        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);

        audio.clip = commandhubDesc;
        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        cameraControls.GetComponent<RTS_Camera>().enabled = true;
    }
}
