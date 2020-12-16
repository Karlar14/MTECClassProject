using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
   
{
   
    public float speed = 30;

    public GameObject theBullet;

    void FixedUpdate(){
        float horzMove = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(horzMove,0) * speed * Time.deltaTime;
    }

    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Instantiate(theBullet,transform.position, Quaternion.identity);    //Quaternion make sure the bullets don't rotate
        }
    }
}
