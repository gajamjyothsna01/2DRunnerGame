using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    /* public float speed;
     private Rigidbody2D myBody;
     // Start is called before the first frame update
     void Awake()
     {
         myBody = GetComponent<Rigidbody2D>();
     }

     // Update is called once per frame
     void FixedUpdate()
     {
         myBody.velocity = new Vector2(speed, myBody.velocity.y);

     }
     private void OnCollisionEnter2D(Collision2D collision)
     {
         if(collision.gameObject.tag == "Player")
         {

         }
     }*/
    public float enemySpeed = 5;
    float time;

    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
}
