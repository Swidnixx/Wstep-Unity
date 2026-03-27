using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int hp = 5; // Health, can be changed in Unity Inspector
    private float iFrameTimer = 0f; 
    public float iFrameDuration = 1f; // How long the i-frames are

    void Update()
    {
        if (iFrameTimer >0f)
        {
            iFrameTimer -= Time.deltaTime;
        }
        // The same if can be: if (iFrameTimer >0f) iFrameTimer -= Time.deltaTime;
        // If an if statement is only one line, you dont need to add the "{}" brackets. Once an if has more than 2 lines, they are necessary.
    } 
    
    public void TakeDamage(int amount)
    {
        if (iFrameTimer>0f) return; // If there are still i-frames, it just ignores the hit.
        hp -=amount;
        iFrameTimer = iFrameDuration;
        Debug.Log(hp);
        if (hp<=0)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
