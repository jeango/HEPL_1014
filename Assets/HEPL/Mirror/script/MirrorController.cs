using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorController : MonoBehaviour
{
    public float XMin;
    public float XMax;
    public float YMin;
    public float YMax;
    private Vector2 target;
    public int speed;
    public Vector2 direction;
    public Rigidbody2D body;

    private void Start()
    {
        ChooseTarget();
    }

    void Update()
    {
        if (!body || body.isKinematic)
        {
            Move();
        }
    }
    void FixedUpdate()
    {
        if (body && !body.isKinematic)
        {
            MoveDynamic();
        }
    }
    private void MoveDynamic()
    {
        body.velocity = direction.normalized * speed;
    }
    private void Move()
    {
        var distanceToTarget = Vector2.Distance((Vector2)transform.position, target);
        var destinationReached = (distanceToTarget <= speed * Time.deltaTime);
        if (destinationReached)
        {
            transform.position = target;
            ChooseTarget();
        }
        else
        {
            var currentPosition = transform.position;
            currentPosition += Time.deltaTime * speed * (Vector3)direction.normalized;
            transform.position = currentPosition;
        }
    }
    void ChooseTarget()
    {
        target.x = Random.Range(XMin, XMax);
        target.y = Random.Range(YMin, YMax);
        direction = target - (Vector2)transform.position;
    }
}
