using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnInterval = 0.5f;
    public float maxYOffset = 4.5f;

    private void OnEnable()
    {
        InvokeRepeating("Spawn", 0, spawnInterval);
    }
    private void OnDisable()
    {
        CancelInvoke("Spawn");
    }

    public void Spawn()
    {
        var yOffset = Random.Range(-maxYOffset, maxYOffset);
        Instantiate(objectToSpawn, transform.position + new Vector3(0, yOffset), transform.rotation);    
    }
}
