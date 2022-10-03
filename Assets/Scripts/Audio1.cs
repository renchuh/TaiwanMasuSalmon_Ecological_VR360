using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio1 : MonoBehaviour
{

    public AudioClip audioA;
    public AudioClip audioB;
    public AudioSource AudioSrc;


    public void playA()
    {
        AudioSrc.PlayOneShot(audioA);
    }

    public void playB()
    {
        AudioSrc.PlayOneShot(audioB);
    }
}
