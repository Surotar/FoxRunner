using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    void Awake() { instance = this; }
    //Sound Effects
    public AudioClip sfx_jumping, sfx_pickup, sfx_enemyKilled;
    //Sound Object
    public GameObject soundObject;

    public void PlaySFX(string sfxName)
    {
        switch (sfxName)
        {
            case "jump":
                SoundObjectCreation(sfx_jumping);
                break;
            case "pickup":
                SoundObjectCreation(sfx_pickup);
                break;
            case "enemy":
                SoundObjectCreation(sfx_enemyKilled);
                break;
            default:
                break;
        }
    }

    void SoundObjectCreation(AudioClip clip)
    {
        //Create SoundsObject gameobject
        GameObject newObject = Instantiate(soundObject, transform);
        //Assign audioclip to its audiosource
        newObject.GetComponent<AudioSource>().clip = clip;
        //Play the audio
        newObject.GetComponent<AudioSource>().Play();
    }
}