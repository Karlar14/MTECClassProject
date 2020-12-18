using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public static float speed = 1f;
    static bool moveRight = true;
    GameObject go;
    public Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        go = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(moveRight)
        {
            myTransform.position += new Vector3(0.01f,0,0) * speed;
            if(myTransform.position.x >= 8){
                moveRight = !moveRight;
            }
        }
        else
        {
            myTransform.position -= new Vector3(0.01f,0,0) * speed;
            if(myTransform.position.x <= -8){
                moveRight = !moveRight;
            }
        } 
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if(col.gameObject.tag == "Bullet")
        {
            Object.Destroy(gameObject);
        }
    }
}