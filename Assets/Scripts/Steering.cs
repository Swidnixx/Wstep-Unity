using UnityEngine;

public class Steering : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(-10, 0, 0);
    }

    void Update()
    {
        transform.position += new Vector3(0.01f, 0, 0);
    }
}
