using UnityEngine;

public class Player : MonoBehaviour
{
    void OnDestroy()
    {
        GameManager.GameOver();
    }
}
