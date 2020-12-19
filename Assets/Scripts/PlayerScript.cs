using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
   
{
   
    public float speed = 300;

    public GameObject theBullet;

    void FixedUpdate(){
        float horzMove = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(horzMove,0) * speed;
    }

    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(theBullet,transform.position + Vector3.up, Quaternion.identity);    //Quaternion make sure the bullets don't rotate
        }
    }
}
