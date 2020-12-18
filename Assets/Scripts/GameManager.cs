using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject blue;
    public GameObject green;
    public GameObject yellow;
    public GameObject orange;
    public GameObject pink;
    void Start()
    {
        float x = (float)-8.25;
        float y = (float)4.5;
        for(int i = 0; i < 8; i++)
        {
            Instantiate(blue, new Vector3(x, y, 0), Quaternion.identity);
            y -= 1;
            Instantiate(green, new Vector3(x, y, 0), Quaternion.identity);
            y -= 1;
            Instantiate(yellow, new Vector3(x, y, 0), Quaternion.identity);
            y -= 1;
            Instantiate(pink, new Vector3(x, y, 0), Quaternion.identity);
            y -= 1;
            Instantiate(orange, new Vector3(x, y, 0), Quaternion.identity);
            x += (float)1.25;
            y = (float) 4.5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
