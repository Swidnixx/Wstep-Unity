using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    void OnMouseDown()
    {
        // Only fires when THIS object is clicked directly!
        GetComponent<SpriteRenderer>().color = Random.ColorHSV();
    }
}