using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 7f; // The force of the jump, can be changed in Unity Inspector
    private bool isGrounded=false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) &&  isGrounded) // If space is pressed and the player is grounded
        {
          rb.linearVelocity = new Vector2(rb.linearVelocity.x,jumpForce); // A script to make the jump more smooth (linear) and predictable
          isGrounded=false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision) // When player touches ANY surface
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

    }
        void OnCollisionExit2D(Collision2D collision) // When player stops touching surface
    {
        isGrounded = false;
    }
}
