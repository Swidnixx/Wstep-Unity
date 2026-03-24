using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D rb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 300);
        }
    }
}
