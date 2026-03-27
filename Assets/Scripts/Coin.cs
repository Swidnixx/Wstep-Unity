using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject winText;
    void Update()
    {
        // This makes the coin spin constantly on the y axis
        transform.Rotate(0,1,0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // If the thing touching the object has the tag "Player", destroy the object
        if (other.CompareTag("Player"))
        {
            Camera.main.transform.SetParent(null); // Save the camera before killing the player
            Destroy(other.gameObject); // Kill the player
            winText.SetActive(true); // Display the win text
            Destroy(gameObject); // Kill the coin
        }
    }
}
