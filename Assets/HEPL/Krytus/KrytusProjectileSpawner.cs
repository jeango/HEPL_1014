using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrytusProjectileSpawner : MonoBehaviour
{
    public GameObject projectileToInstanciate;

    public int numberOfProjectiles;
    float angleInterval;

    // Start is called before the first frame update
    void Start()
    {
        angleInterval = 360f / numberOfProjectiles;
        Spawner();

        Destroy(gameObject);
    }

    void Spawner()
    {
        for (int i = 0; i < numberOfProjectiles; i++)
        {
            float spawnAngle = i * angleInterval;

            Instantiate(projectileToInstanciate, gameObject.transform.position, Quaternion.Euler(0, 0, spawnAngle));
        }

        
    }

}
