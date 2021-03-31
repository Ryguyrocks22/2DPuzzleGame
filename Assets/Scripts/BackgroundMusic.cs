﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource Track1;
    public AudioSource Track2;

    public int TrackSelector;

    public int TrackHistory;

    private void Start()
    {
        TrackSelector = Random.Range(0, 2);

        if(TrackSelector == 0)
        {
            Track1.Play();
            TrackHistory = 1;
        }
        else if (TrackSelector == 1)
        {
            Track2.Play();
            TrackHistory = 2;
        }
    }

    private void Update()
    {
        if(Track1.isPlaying == false && Track2.isPlaying == false)
        {
            TrackSelector = Random.Range(0, 2);

            if (TrackSelector == 0 && TrackHistory != 1)
            {
                Track1.Play();
                TrackHistory = 1;
            }
            else if (TrackSelector == 1 && TrackHistory != 2)
            {
                Track2.Play();
                TrackHistory = 2;
            }
        }
    }
    static BackgroundMusic instance = null;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
    }
}
