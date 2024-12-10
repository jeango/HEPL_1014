using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrytusProjectileMouvement : MonoBehaviour
{
    public Vector3 direction;
    public int speed;


    private void Start()
    {
        // cette ligne permet d'orienter direction de la meme maniere que l'axe y local de l'objet,
        // permet d'alligner la direction sur la rotation effectuee lors de l'instantiation
        direction = transform.up;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        var currentPosition = transform.position;
        currentPosition += Time.deltaTime * speed * direction.normalized;
        transform.position = currentPosition;
    }
}
