using UnityEngine;
using UnityEngine.InputSystem;
using System;
using System.IO;

public class MovementBeamer : MonoBehaviour {
    public Vector2 direction;
    public float startSpeed;
    public float brakes;
    private float speed;
    public float waitTime;
    private bool CanStop;
    private float _waitTimer;
    private BoxCollider2D boxCollider2D;
    private LineRenderer lineRenderer;
    private Animator animator;


    // Start is called before the first frame update
    void Start() {
        speed = startSpeed;
        CanStop = true;
        boxCollider2D = GetComponent<BoxCollider2D>();
        lineRenderer = GetComponent<LineRenderer>();  
        lineRenderer.enabled = false;
    }
    void Awake() {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update() {
        if (_waitTimer > 0f) {
            _waitTimer -= Time.deltaTime;
            Debug.Log(_waitTimer);
            return;
        }
        boxCollider2D.offset = new Vector2(0, 0); // Adjust the offset (Y=25)
        boxCollider2D.size = new Vector2(boxCollider2D.size.x, 1);
        lineRenderer.enabled = false;
        Move();
        speed = speed - brakes * Time.deltaTime;

        if (CanStop == true) {
            if (speed <= 0) {
                CanStop = false;
                _waitTimer = waitTime;
                boxCollider2D.offset = new Vector2(0, 25); // Adjust the offset (Y=25)
                boxCollider2D.size = new Vector2(boxCollider2D.size.x, 50);
                lineRenderer.enabled = true;
                animator.Play("BeamerBeam", 0, 0f);
            }
        }

        void Move() {

            var currentPosition = transform.position;
            currentPosition += Time.deltaTime * speed * (Vector3)direction.normalized;
            transform.position = currentPosition;

        }

    }
}

 
   
   


