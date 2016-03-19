using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public PlayerInfo playerInfo;
    
    float moveVelocity;

    private bool grounded;

    
    private int jumpTimes;
    
    void Update()
    {
        if (!playerInfo.IsLive()) return;
        //Jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpTimes > 0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, playerInfo.jump);
                jumpTimes--;
            }
        }

        moveVelocity = 0;

        //Left Right Movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveVelocity = -playerInfo.speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveVelocity = playerInfo.speed;
        }

        if (Input.GetKey(KeyCode.UpArrow) && grounded)
        {
            moveVelocity *= 2;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

    }
    //Check if Grounded
    void OnTriggerEnter2D(Collider2D other)
    {
        grounded = true;
        jumpTimes = playerInfo.defaultJumpTimes;
    }
    void OnTriggerExit2D()
    {
        grounded = false;
    }
}