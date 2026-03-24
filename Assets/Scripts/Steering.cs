using UnityEngine;

public class Steering : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(-10, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.01f, 0, 0);
    }
}
