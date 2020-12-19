using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public static float speed = 1f;
    static bool moveRight = true;
    GameObject go;
    public Transform myTransform;
    public GameObject EnemyBullet;
    float nextShot = 0;
    float fireRate = 2f;
    int value = 1;
    // Start is called before the first frame update
    void Start()
    {
        go = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D playerCheck = Physics2D.Raycast(transform.position, Vector2.down, 30f, LayerMask.GetMask("Player"));
        if(playerCheck)
        {
            if(Time.time > nextShot)
                    {

                        Vector2 BulletPosition = new Vector2(myTransform.position.x, myTransform.position.y -(float)0.5f);
                        nextShot = Time.time + fireRate;
                        Instantiate(EnemyBullet, BulletPosition, Quaternion.identity);

                    }
        }
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
            GameObject scorekeeper = GameObject.Find("ScoreKeeper");
                ScoreKeeper score = scorekeeper.GetComponent<ScoreKeeper>();
                score.increment(value);
            Object.Destroy(gameObject);

        }
    }
}