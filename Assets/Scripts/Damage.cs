using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public string[] tagsToDamage;
    public bool canKill;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (tagsToDamage.Contains(other.attachedRigidbody?.tag))
        {
            var otherObject = other.attachedRigidbody?.gameObject;
            var deathCtrl = otherObject?.GetComponent<DeathController>();
            if (canKill && deathCtrl != null)
            {
                deathCtrl.Kill();
            }
            else
            {
                Destroy(otherObject);
            }
        }
    }

}
