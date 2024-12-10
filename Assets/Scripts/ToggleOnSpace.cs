using UnityEngine;

public class ToggleOnSpace : MonoBehaviour
{
    public GameObject[] objectsToToggle;

    private Spawner currentSpawner;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Toggle();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnAllObjects();
        }
    }

    private void SpawnAllObjects()
    {
        
        foreach (GameObject obj in objectsToToggle)
        {
            currentSpawner = obj.GetComponent<Spawner>();
            if (currentSpawner)
            {
                currentSpawner.Spawn();
            }
        }
    }

    void Toggle()
    {
        foreach (var obj in objectsToToggle)
        {
            obj.SetActive(!obj.activeSelf);
        }
    }
    
}
