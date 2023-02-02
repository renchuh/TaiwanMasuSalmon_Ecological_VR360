using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoStartTimer : MonoBehaviour
{
    public float setTimer;
    public float timer;
    bool GvrStatus;

    public VideoPlayer[] Video;
    public AudioSource[] Source;
    //public VideoPlayer Video_2;

    public void GVRon()
    {
        GvrStatus = true;
    }

    public void GVRoff()
    {
        GvrStatus = false;
        timer = 0;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GvrStatus)
        {
            timer += Time.deltaTime;

        }

        if (timer >= setTimer)
        {
            for (int i = 0; i < Video.Length; i++)
            {
                Video[i].Play();
            }
        }
    }
}
