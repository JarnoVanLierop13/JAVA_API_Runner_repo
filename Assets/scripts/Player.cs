using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float maxSpeed = 7.5f;
    public float speed = 50f;
    public float jumpHeight = 150f;

    public bool grounded;

    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        
        if(Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(Vector2.up * jumpHeight);
        }

        var velocity = Vector2.right * maxSpeed;
        rb2d.MovePosition(rb2d.position + velocity * Time.deltaTime);

    }

   // void FixedUpdate()
   // {

        //float h = Input.GetAxis("Horizontal");

        //actual movement
        //rb2d.AddForce((Vector2.right * speed) * h);

        // limits player speed
       // if(rb2d.velocity.x > maxSpeed)
       // {
         //   rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        //}

       // if (rb2d.velocity.x < -maxSpeed)
       // {
        //    rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        //}

    //}
}
