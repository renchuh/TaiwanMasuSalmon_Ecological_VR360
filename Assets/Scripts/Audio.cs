using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour { 

    public AudioClip audioA;
    public AudioClip audioB;
    public AudioSource AudioSrc;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playA()
    {
        AudioSrc.PlayOneShot(audioA);
    }

    public void playB()
    {
        AudioSrc.PlayOneShot(audioB);
    }
}
