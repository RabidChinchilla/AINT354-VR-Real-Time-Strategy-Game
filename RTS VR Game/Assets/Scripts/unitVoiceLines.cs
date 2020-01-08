using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitVoiceLines : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip normal1;
    public AudioClip normal2;
    public AudioClip normal3;
    public AudioClip normal4;
    public AudioClip normal5;
    public AudioClip normal6;
    public AudioClip normal7;
    public AudioClip normal8;

    public AudioClip combat1;
    public AudioClip combat2;
    public AudioClip combat3;
    public AudioClip combat4;

    public AudioClip hurt1;
    public AudioClip hurt2;
    public AudioClip hurt3;
    public AudioClip hurt4;

    public AudioSource player;
    int number;
    void Start()
    {
        int number = Random.Range(1, 20);
        //Debug.Log(number);
        StartCoroutine(PlayMoveAudio(number));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator PlayMoveAudio(int number)
    {
        number = Random.Range(1, 20);

        //Debug.Log(number);
        if (number == 8)
        {
            player.clip = normal8;
            player.Play();
            yield return new WaitForSecondsRealtime(12.0f);
            StartCoroutine(PlayMoveAudio(number));
        }
        if (number == 7)
        {
            player.clip = normal7;
            player.Play();
            yield return new WaitForSecondsRealtime(12.0f);
            StartCoroutine(PlayMoveAudio(number));
        }
        if (number == 6)
        {
            player.clip = normal6;
            player.Play();
            yield return new WaitForSecondsRealtime(12.0f);
            StartCoroutine(PlayMoveAudio(number));
        }
        if (number == 5)
        {
            player.clip = normal5;
            player.Play();
            yield return new WaitForSecondsRealtime(12.0f);
            StartCoroutine(PlayMoveAudio(number));
        }
        if (number == 4)
        {
            player.clip = normal4;
            player.Play();
            yield return new WaitForSecondsRealtime(12.0f);
            StartCoroutine(PlayMoveAudio(number));
        }
        if (number == 3)
        {
            player.clip = normal3;
            player.Play();
            yield return new WaitForSecondsRealtime(12.0f);
            StartCoroutine(PlayMoveAudio(number));
        }
        if (number == 2)
        {
            player.clip = normal2;
            player.Play();
            yield return new WaitForSecondsRealtime(12.0f);
            StartCoroutine(PlayMoveAudio(number));
        }
        if (number == 1)
        {
            player.clip = normal1;
            player.Play();
            yield return new WaitForSecondsRealtime(12.0f);
            StartCoroutine(PlayMoveAudio(number));
        }
        if (number > 8)
        {
            StartCoroutine(PlayMoveAudio(number));
            yield return new WaitForSecondsRealtime(12.0f);
        }
    }

    public IEnumerator PlayAttackAudio(int number)
    {
        if (number == 4)
        {
            player.clip = combat4;
            player.Play();
            yield return new WaitForSeconds(player.clip.length);
        }
        if (number == 3)
        {
            player.clip = combat3;
            player.Play();
            yield return new WaitForSeconds(player.clip.length);
        }
        if (number == 2)
        {
            player.clip = combat2;
            player.Play();
            yield return new WaitForSeconds(player.clip.length);
        }
        if (number == 1)
        {
            player.clip = combat1;
            yield return new WaitForSeconds(player.clip.length);
        }
    }
    public IEnumerator PlayInjuredAudio(int number)
    {
        if (number == 4)
        {
            player.clip = hurt4;
            player.Play();
            yield return new WaitForSeconds(player.clip.length);
        }
        if (number == 3)
        {
            player.clip = hurt3;
            player.Play();
            yield return new WaitForSeconds(player.clip.length);
        }
        if (number == 2)
        {
            player.clip = hurt2;
            player.Play();
            yield return new WaitForSeconds(player.clip.length);
        }
        if (number == 1)
        {
            player.clip = hurt1;
            yield return new WaitForSeconds(player.clip.length);
        }
    }
}
