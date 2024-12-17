using UnityEngine;

public class SpeedPowerupPickup : MonoBehaviour
{
    public int speedBoost;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        var movement = other.GetComponent<MovementController>();
        if (movement)
        {
            movement.speed += speedBoost;
        }
        Destroy(gameObject);
    }
}