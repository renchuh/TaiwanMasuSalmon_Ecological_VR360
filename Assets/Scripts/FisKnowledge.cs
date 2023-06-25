using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisKnowledge : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject clickPointA;
    public GameObject showPrefabA;
    public GameObject clickPointB;
    public GameObject showPrefabB;
    public GameObject clickPointC;
    public GameObject showPrefabC;
    public GameObject clickPointD;
    public GameObject showPrefabD;
    public GameObject clickPointE;
    public GameObject showPrefabE;
    public GameObject clickPointF;
    public GameObject showPrefabF;

    [SerializeField] private float timer = 0;
    public float nSecond = 1f;
    private bool entered = false;

    [SerializeField] private string funName;
    [SerializeField] private bool IsOpening = false;



    void Start()
    {
        showPrefabA.SetActive(false);
        showPrefabB.SetActive(false);
        showPrefabC.SetActive(false);
        showPrefabD.SetActive(false);
        showPrefabE.SetActive(false);
        showPrefabF.SetActive(false);
        timer = 0;
        entered = false;

    }

    // Update is called once per frame
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
                Invoke(funName, 0f);
                entered = false;
                timer = 0.0f;
            }
        }
    }

    public void InvokeFun(string funName)
    {
        entered = true;
        this.funName = funName;
    }

    public void CancelInvokeFun()
    {
        if (!IsOpening)
        {
            entered = false;
            this.funName = string.Empty;
            timer = 0;
        }
    }

    public void clickA()
    {
        IsOpening = true;
        showPrefabA.SetActive(true);
        clickPointA.SetActive(false);

    }
    public void closeA()
    {
        IsOpening = false;
        showPrefabA.SetActive(false);
        clickPointA.SetActive(true);
    }

    public void clickB()
    {
        IsOpening = true;
        showPrefabB.SetActive(true);
        clickPointB.SetActive(false);
    }
    public void closeB()
    {
        IsOpening = false;
        showPrefabB.SetActive(false);
        clickPointB.SetActive(true);

    }

    public void clickC()
    {
        IsOpening = true;
        showPrefabC.SetActive(true);
        clickPointC.SetActive(false);
    }
    public void closeC()
    {
        IsOpening = false;
        showPrefabC.SetActive(false);
        clickPointC.SetActive(true);

    }

    public void clickD()
    {
        IsOpening = true;
        showPrefabD.SetActive(true);
        clickPointD.SetActive(false);
    }
    public void closeD()
    {
        IsOpening = false;
        showPrefabD.SetActive(false);
        clickPointD.SetActive(true);

    }

    public void clickE()
    {
        IsOpening = true;
        showPrefabE.SetActive(true);
        clickPointE.SetActive(false);
    }
    public void closeE()
    {
        IsOpening = false;
        showPrefabE.SetActive(false);
        clickPointE.SetActive(true);

    }

    public void clickF()
    {
        IsOpening = true;
        showPrefabF.SetActive(true);
        clickPointF.SetActive(false);
    }
    public void closeF()
    {
        IsOpening = false;
        showPrefabF.SetActive(false);
        clickPointF.SetActive(true);

    }
}
