using UnityEngine;

namespace HEPL.B11014
{
    
public class DeathController : MonoBehaviour
{
    public int scoreOnDeath;
    public GameObject deathEffect;
    public PowerupGenerator powerupGenerator;

    public void Kill()
    {
        Die();
    }
    
    void Die()
    {
        powerupGenerator?.GeneratePowerup(transform.position);
        GameManager.score += scoreOnDeath;
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
}

