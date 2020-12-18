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
        // Destroy(gameObject, 3);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject,05f);
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
