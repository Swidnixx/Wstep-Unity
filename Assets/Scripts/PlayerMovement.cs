using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f; // // Movement speed, can be changed in Unity Inspector

    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        // This moves the player based on what keys are pressed (WASD/Arrow keys)
        rb.linearVelocity=new Vector2(x*speed,rb.linearVelocity.y);
    }
}
