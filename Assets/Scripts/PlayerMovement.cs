using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        // This moves the player based on what keys are pressed (WASD/Arrow keys)
        transform.Translate(new Vector3(x, 0, 0) * speed * Time.deltaTime);
    }
}
