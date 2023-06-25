using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IconChange : MonoBehaviour
{
    public List<string> ChangedSceneName;
    public Sprite ChangedIcon;
    public Sprite CanClickedIcon;
    public Image Bin;
    public int selfIndex;
    public EventTrigger EventTrigger;
    private Button btn;
    void Start()
    {
        EventTrigger = transform.parent.GetComponentInChildren<EventTrigger>();
        btn = EventTrigger.GetComponent<Button>();
        selfIndex = this.transform.parent.GetSiblingIndex();
        EventTrigger.enabled = selfIndex==0;
        btn.enabled = selfIndex == 0;
        if (GetSceneLoadOver())
        {
            Bin.sprite = ChangedIcon;
            EventTrigger.enabled = true;
            btn.enabled = true;
            HomeUI.Instance.AddProgress(1 / 4.0f);
            if(selfIndex<4)
                transform.root.GetChild(++selfIndex).GetComponentInChildren<IconChange>().CanClicked();
        }

      
    }

    public void CanClicked()
    {
        Bin.sprite = CanClickedIcon;
        EventTrigger.enabled = true;
        btn.enabled = true;
    }
    
    private bool GetSceneLoadOver()
    {
        for (var i = 0; i < ChangedSceneName.Count; i++)
        {
            if (!SceneLoadMark.Instance.LoadedSceneName.Contains(ChangedSceneName[i]))
            {
                return false;
            }
        }

        return true;
    }
}
