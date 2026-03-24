using NUnit.Framework;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 7f;
    private bool isGrounded=false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) &&  isGrounded)
        {
          rb.linearVelocity = new Vector2(rb.linearVelocity.x,jumpForce);
          isGrounded=false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
        void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
