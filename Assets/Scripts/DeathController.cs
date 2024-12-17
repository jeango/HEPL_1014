using UnityEngine;

public class DeathController : MonoBehaviour
{
    public int scoreOnDeath;
    public GameObject deathEffect;

    public void Kill()
    {
        Die();
    }
    
    void Die()
    {
        GameManager.score += scoreOnDeath;
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
