using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int hp =5; // Health, can be changed in Unity Inspector
    
    public void TakeDamage(int amount)
    {
        hp -=amount;
        Debug.Log(hp);
        if (hp<=0)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
