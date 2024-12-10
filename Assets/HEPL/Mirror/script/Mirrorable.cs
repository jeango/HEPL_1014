using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirrorable : MonoBehaviour
{
    public GameObject mirrorPrefab;
    public void Mirror()
    {
        Instantiate(mirrorPrefab, transform.position, Quaternion.identity);
    }
}
