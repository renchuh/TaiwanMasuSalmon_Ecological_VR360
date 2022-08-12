using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImg : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject clickImgA;
    public GameObject showImgA;
 


    void Start()
    {
        showImgA.SetActive(false);

    }

    public void clickA()
    {
        showImgA.SetActive(true);
        clickImgA.SetActive(false);
    }

    public void closeA()
    {
        showImgA.SetActive(false);
        clickImgA.SetActive(true);
    }
}
