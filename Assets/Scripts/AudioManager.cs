using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private void Awake(){ instance = this; }

    //Sound Effects
    public AudioClip sfx_jump, sfx_landing;

    //Sound object
    public GameObject soundObject;

    public void PlaySFX(string sfxName)
    {
        switch(sfxName)
        {
            case "landing":
                SoundObjectCreation(sfx_landing);
                break;
            case "jumping":
                SoundObjectCreation(sfx_jump);
                break;
            default:
                break;
        }
    }

    void SoundObjectCreation(AudioClip clip)
    {
        //Create soundobject gameobject
        GameObject newObject = Instantiate(soundObject, transform);
        //Assign audioclip to its audiosource
        newObject.GetComponent<AudioSource>().clip = clip;
        //play audio
        newObject.GetComponent<AudioSource>().Play();
    }
}
