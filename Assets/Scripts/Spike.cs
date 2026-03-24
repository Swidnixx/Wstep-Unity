using UnityEngine;

public class Spike : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().TakeDamage(2); // The same way we do it in bullet.cs, getting the function TakeDamage from PlayerHealth
        }
    }
}
