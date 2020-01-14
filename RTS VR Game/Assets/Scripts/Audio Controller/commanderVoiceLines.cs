﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class commanderVoiceLines : MonoBehaviour
{
    public AudioClip normal1;
    public AudioClip normal2;
    public AudioClip normal3;
    public AudioClip normal4;
    public AudioClip normal5;
    public AudioClip normal6;
    public AudioClip normal7;

    public AudioSource player;
    // Start is called before the first frame update
    void Start()
    {
        int number = Random.Range(1, 20);
        //Debug.Log(number);
        StartCoroutine(PlayMoveAudio(number));
    }

    // Update is called once per frame
    public IEnumerator PlayMoveAudio(int number)
    {
        number = Random.Range(1, 20);

        //Debug.Log(number);
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
        if (number > 7)
        {
            yield return new WaitForSecondsRealtime(12.0f);
            StartCoroutine(PlayMoveAudio(number));
        }
    }
}