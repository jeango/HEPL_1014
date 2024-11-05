using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public Vector2 direction;
    public int speed;
    public Rigidbody2D body;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
    
    public void SetDirection(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
    
    private void Move()
    {
         var currentPosition = transform.position;
         currentPosition += Time.deltaTime * speed * (Vector3)direction.normalized;
         transform.position = currentPosition;       
    }




    
}
