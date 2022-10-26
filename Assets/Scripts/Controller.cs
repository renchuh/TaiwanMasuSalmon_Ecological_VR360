using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject clickPointA;
    public GameObject showPrefabA;
    public GameObject clickPointB;
    public GameObject showPrefabB;
    public GameObject clickPointC;
    public GameObject showPrefabC;


    private float timer = 0;
    public float rsSecond = 1f;
    private bool entered = false;


    void Start()
    {
       showPrefabA.SetActive(false);
       showPrefabB.SetActive(false);
       showPrefabC.SetActive(false);
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
            if (timer >= rsSecond)
            {
                entered = false;
                timer = 0.0f;
            }
        }
    }

    public void click()
    {
        entered = true;
    }
    public void exict()
    {
        entered = false;
        timer = 0.0f;
    }

    public void clickA()
    {
        entered = true;
        showPrefabA.SetActive(true);
        clickPointA.SetActive(false);

    }
    public void closeA()
    {
        entered = false;
        timer = 0.0f;
        showPrefabA.SetActive(false);
        clickPointA.SetActive(true);
    }

    public void clickB()
    {
        entered = true;
        showPrefabB.SetActive(true);
        clickPointB.SetActive(false);

    }
    public void closeB()
    {
        entered = false;
        timer = 0.0f;
        showPrefabB.SetActive(false);
        clickPointB.SetActive(true);
    }

    public void clickC()
    {
        entered = true;
        showPrefabC.SetActive(true);
        clickPointC.SetActive(false);

    }
    public void closeC()
    {
        entered = false;
        timer = 0.0f;
        showPrefabC.SetActive(false);
        clickPointC.SetActive(true);
    }


}
