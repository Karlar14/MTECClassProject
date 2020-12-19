using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    static int lives = 3;
    public float speed = 20;

    private Rigidbody2D rb;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
        // Destroy(gameObject, 3);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Bullet")
        {
           

            Destroy(col.gameObject);
            Destroy(gameObject);


        }

        if(col.gameObject.tag == "Player")
        {
            lives--;
            if(lives <= 0)
            {
                Destroy(col.gameObject);
            }
            Destroy(gameObject);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, -5);
        Destroy(gameObject, 3f);
    }
}
