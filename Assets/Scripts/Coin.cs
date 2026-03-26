using UnityEngine;

public class Coin : MonoBehaviour
{
    void Update()
    {
        // This makes the coin spin constantly
        transform.Rotate(0,1,0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // If the thing touching the object has the tag "Player", destroy the object
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
