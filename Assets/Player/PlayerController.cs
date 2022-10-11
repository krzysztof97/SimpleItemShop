using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 500f;
    [SerializeField] float jumpForce = 500f;
    bool isJumping;

    const float RAYCAST_OFFSET = 0.1f;

    Rigidbody2D rb;
    BoxCollider2D boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ProcessMovement();
        ProcessJump();
    }

    void ProcessMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.AddForce(Time.deltaTime * moveHorizontal * speed * Vector2.right);
    }

    void ProcessJump()
    {
        if (CheckGrounded())
        {
            isJumping = false;
        }

        if (isJumping)
        {
            return;
        }

        bool jumpTriggered = Input.GetAxis("Jump") > 0;

        if(jumpTriggered)
        {
            rb.AddForce(jumpForce * Vector2.up);
            isJumping = true;
        }
    }

    bool CheckGrounded()
    {
        Vector2 origin = new Vector2(transform.position.x, transform.position.y - boxCollider.size.y/2 - RAYCAST_OFFSET);
        RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.down, RAYCAST_OFFSET);
        return hit.collider != null;
    }
}
