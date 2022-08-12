using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalFlock : MonoBehaviour
{
    public GameObject sakuPrefab;
    public GameObject goalPrefab;
    public static int tankSize = 5;

    static int numFish = 30;
    public static GameObject[] allSaku = new GameObject[numFish];

    public static Vector3 goalPos = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < numFish; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-tankSize, tankSize),
                                      Random.Range(-tankSize, tankSize),
                                      Random.Range(-tankSize, tankSize));
            allSaku[i] = (GameObject)Instantiate(sakuPrefab, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.Range(0,10000) < 50)
        {
            goalPos = new Vector3(Random.Range(-tankSize, tankSize - 2),
                                  Random.Range(-tankSize, tankSize - 2),
                                  Random.Range(-tankSize, tankSize - 2));
            goalPrefab.transform.position = goalPos;
        }
    }
}
