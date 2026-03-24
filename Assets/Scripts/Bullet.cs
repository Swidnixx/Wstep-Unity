using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f; // Speed of the bullet

    void Start()
    {
        // Deletes the bullet after 1s (feels longer?)
        Destroy(gameObject, 1f);
    }

    void Update()
    {
        // Makes the bullet constantly fly forward
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
