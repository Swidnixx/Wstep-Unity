using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform player;       // Drag the Player here
    public GameObject bullet;      // Drag the Bullet prefab here
    public Transform spawnPoint;   // Drag the tip of the barrel here

    public float range = 7f;       // How close the player needs to be
    public float fireRate = 2f;    // Shoots every 2 seconds
    private float timer = 0f;      // Timer to keep track of how long its been since the last shot

    void Update()
    {
        // Check how far away the player is
        float distance = Vector2.Distance(transform.position, player.position);

        // If the player is inside the range
        if (distance <= range)
        {
            // Aim at the player
            Vector2 direction = player.position - transform.position;
            transform.right = direction;

            // If enough time has passed, shoot
            if (timer >= fireRate)
            {
                Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                timer = 0f; // Reset the timer after shooting
            }
        }

        // Always keep the timer ticking up
        timer += Time.deltaTime;
    }
}
