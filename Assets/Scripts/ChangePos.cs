using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangePos : MonoBehaviour
{
    private float timer = 0;
    public float nSecond = 1f;
    private bool entered = false;
    private string SceneName;


    public GameObject Player;

    void Start()
    {
        timer = 0;
        entered = false;
    }

    void Update()
    {
        //If pointer is pointing on the object, start the timer
        if (entered == true)
        {
            //Increment timer
            timer += Time.deltaTime;

            //Load scene if counter has reached the nSecond
            if (timer >= nSecond)
            {
                SwitchScene(SceneName);
                entered = false;
                timer = 0.0f;
            }
        }
    }
    public void click(string name)
    {
        entered = true;
        SceneName = name;
        Debug.Log("clicking"+SceneName);
    }
    public void exict()
    {
        entered = false;
        timer = 0.0f;
    }

    public void SwitchScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
