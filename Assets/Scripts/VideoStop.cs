using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Audio;

public class VideoStop : MonoBehaviour
{
    public float Settimer;
    public float timer;
    bool Timer;
    public VideoPlayer Video;
    public AudioSource Sound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Timer)
        {
            timer += Time.deltaTime;
        }

        if (timer >= Settimer)
        {
            Video.Stop();
            Sound.Play();
        }
    }

    public void VRon()
    {
        Timer = true;
    }

    public void VRoff()
    {
        Timer = false;
        timer = 0;
    }
}
