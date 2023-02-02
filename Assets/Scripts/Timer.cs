using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public float setTimer;
    public float timer;
    bool GvrStatus;

    public UnityEvent VR_timer;

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
            VR_timer.Invoke();
        }
    }
}
