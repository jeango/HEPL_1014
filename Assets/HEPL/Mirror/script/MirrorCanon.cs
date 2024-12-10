using System.Linq;
using UnityEngine;

public class MirrorCannon : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<Mirrorable>()?.Mirror();
    }
}