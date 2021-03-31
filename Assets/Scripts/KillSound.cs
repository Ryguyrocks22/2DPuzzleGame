using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSound : MonoBehaviour
{

    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (!source.isPlaying)
        {
            Debug.Log(name + "Stop playing");
            Destroy(gameObject);
        }
    }
}
