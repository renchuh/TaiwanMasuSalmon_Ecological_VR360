using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HomeUI : MonoBehaviour
{
    public static HomeUI Instance;

    public Slider Sdr_Progress;

    private float progressValue;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            DestroyImmediate(this.gameObject);
        }
    }

    public void AddProgress(float value)
    {
        progressValue += value;
        StartCoroutine(DelayOneAction(() => { Sdr_Progress.value = progressValue; }));
    }

    private IEnumerator DelayOneAction(UnityAction todo)
    {
        yield return new WaitForFixedUpdate();
        todo?.Invoke(); ;
    }
}
