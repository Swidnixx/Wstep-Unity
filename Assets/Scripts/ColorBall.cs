using UnityEngine;

public class ColorBall : MonoBehaviour
{
    public bool isGreen = false; // The door will use this to check whether the balls are green or not
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = Color.red; // Start red (locked)
    }

    void OnMouseDown()
    {
        // When clicked, turn green, set isGreen for the door to know that it turned green.
        if (!isGreen)
        {
            isGreen = true;
            sr.color = Color.green;
        }
    }
}
