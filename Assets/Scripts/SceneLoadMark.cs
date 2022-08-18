using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneLoadMark : MonoBehaviour
{
    public static SceneLoadMark Instance;
    public static List<string> LoadedSceneName;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            LoadedSceneName = new List<string>();
            SceneManager.sceneLoaded += OnSceneLoaded;

        }
        else
        {
            DestroyImmediate(this.gameObject);
        }
    }

    private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        if (LoadedSceneName.Contains(arg0.name))
        {
            return;
        }
        else
        {
            LoadedSceneName.Add(arg0.name);
        }
    }
}
