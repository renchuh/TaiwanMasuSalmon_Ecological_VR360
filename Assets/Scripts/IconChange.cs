using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconChange : MonoBehaviour
{
    public List<string> ChangedSceneName;
    public Sprite ChangedIcon;
    public Image Bin;

    void Start()
    {
        if (GetSceneLoadOver())
        {
            Bin.sprite = ChangedIcon;
            HomeUI.Instance.AddProgress(1 / 8.0f);
        }

    }

    private bool GetSceneLoadOver()
    {
        for (var i = 0; i < ChangedSceneName.Count; i++)
        {
            if (!SceneLoadMark.LoadedSceneName.Contains(ChangedSceneName[i]))
            {
                return false;
            }
        }

        return true;
    }
}
