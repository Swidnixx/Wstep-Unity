using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;

    void Update()
    {
        // 0 means Left Mouse Button!
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
