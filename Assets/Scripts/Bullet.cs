using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; // Speed of the bullet, can be changed inside unity

    void Start()
    {
        Destroy(gameObject, 2f); // Deletes the bullet after 2s (feels longer?)
    }

    void Update()
    {
        // Makes the bullet constantly fly to the right
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().TakeDamage(1); //Makes the player take damage, using the function TakeDamage from PlayerHealth.cs
        }
        Destroy(gameObject); //Outside the if loop so it destroys the object no matter what it hits.
    }
}
