﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 30;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;
        
    }

    void OntriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
   void OnBecomeInvisible()
   {
       Destroy(gameObject);
   }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
