using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{

    private bool canJump;
    private bool isGrounded;
    public Rigidbody rb;
    public float movSpeed = 500f;
    public float forwardSpeed = 1000f;
    public float jumpForce = 6f;

    private bool isPlayer2 = false;
    public Player1Movement swap;

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

        if(collisionInfo.collider.tag == "Player1Trigger")
        {
            isPlayer2 = false;
            swap.swapToPlayer1();
        }

    }
    void FixedUpdate()
    {

        transform.rotation = Quaternion.identity;
        if(isPlayer2)
        {
            rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);
        }

        if(Input.GetKey("d") && isPlayer2)
        {
            rb.AddForce(movSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a") && isPlayer2)
        {
            rb.AddForce(-movSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(canJump && isGrounded && isPlayer2)
        {
            canJump = false;
            isGrounded = false;
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
        }

        if(rb.position.y < -1f && isPlayer2)
        {
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<GameManager>().GameOver();
        }

    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space) && isPlayer2)
        {
            canJump = true;
        }
    }

    public void swapToPlayer2()
    {
        isPlayer2 = true;
    }
}
