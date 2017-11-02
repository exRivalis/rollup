using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float speed;
    private float xOffset;//to deal with jump direction
    private float jumpPressure, minJump, maxJump;
    Rigidbody rb;
    bool onGround;

    //private GameObject player;

	// Use this for initialization
	void Start () {
        speed = 6;
        xOffset = 0;
        rb = GetComponent<Rigidbody>();
        jumpPressure = 0f;
        maxJump = 30f;
        minJump = 8f;
        onGround = false;
        //player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        //xOffset = transform.position.x - xOffset;

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //float movement = moveHorizontal * speed;

        if (Input.GetKey("right"))
        {
            transform.Translate(new Vector3(speed*Time.deltaTime, 0, 0));
            xOffset = speed/2;
           // rb.velocity = Vector3.right * movement;
        }

        if (Input.GetKey("left"))
        {
            transform.Translate(new Vector3(-1 * speed * Time.deltaTime, 0, 0));
            xOffset = -1 * speed/2;// * Time.deltaTime;
        }

        //Debug.Log(xOffset);
        //if not pressed set xOffset to zero to allow jumping only verticaly
        if(Input.GetKeyUp("right") || Input.GetKeyUp("left"))
        {
            xOffset = 0f;
        }

        //jump
        
        //space down
        if (Input.GetKey("space") && onGround)
        {   /*
            if (jumpPressure < maxJump)
            {
                jumpPressure += Time.deltaTime * 5f;
            }
            else
            {
                jumpPressure = maxJump;
            }
            */
            jumpPressure = jumpPressure + minJump;
            rb.AddForce(new Vector3(xOffset, jumpPressure, 0f) * 50);
            jumpPressure = 0f;
        }
        /*//space up
        else
        {
            if(jumpPressure > 0)
            {
                //jumpPressure = jumpPressure + minJump;
                //rb.AddForce(new Vector3(xOffset, jumpPressure, 0f)* 50);
                jumpPressure = 0;
                //onGround = false;
            }
        }
        */
    }
  
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            onGround = true;
            speed = 6;

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            onGround = false;
            speed = 3;
        }
    }

   
}
