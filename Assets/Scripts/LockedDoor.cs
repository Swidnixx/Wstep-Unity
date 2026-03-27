using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    // Drag 3 balls in here for Unity Inspector, required to be able to open the door
    public ColorBall ball1;
    public ColorBall ball2;
    public ColorBall ball3;

    void Update()
    {
        // Check every frame if ALL THREE balls are green
        if (ball1.isGreen && ball2.isGreen && ball3.isGreen)
        {
            // If they are, the door opens (destroys itself)
            Destroy(gameObject);
        }
    }
}
