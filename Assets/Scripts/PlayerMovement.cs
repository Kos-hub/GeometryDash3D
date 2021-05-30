using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private bool canJump;
    private bool isGrounded;
    public Rigidbody rb;
    public float movSpeed = 500f;
    public float forwardSpeed = 1000f;
    public float jumpForce = 6f;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Ground" || collisionInfo.collider.tag == "BossGround" || collisionInfo.collider.tag == "BossJump")
        {
            isGrounded = true;
        }

        if(collisionInfo.collider.tag == "BossJump")
        {
            jumpForce = 40f;
        }else
        {
            jumpForce = 6f;
        }

    }
    void FixedUpdate()
    {

        transform.rotation = Quaternion.identity;
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(movSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-movSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(canJump && isGrounded)
        {
            canJump = false;
            isGrounded = false;
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<GameManager>().GameOver();
        }

        if(rb.position.z > -3.5f)
        {
            forwardSpeed = 0; 
            if(Input.GetKey("w"))
            {
                rb.AddForce(0, 0, movSpeed * Time.deltaTime, ForceMode.VelocityChange);
            }
            if(Input.GetKey("s"))
            {
                rb.AddForce(0, 0, -movSpeed * Time.deltaTime, ForceMode.VelocityChange);
            }

            RenderSettings.fog = false;
        }

    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            canJump = true;
        }
    }
}
