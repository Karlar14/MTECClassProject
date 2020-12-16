using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Bullet")
        {
           

            Destroy(col.gameObject,0.5f);

        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
