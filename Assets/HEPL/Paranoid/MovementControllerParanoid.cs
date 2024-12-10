using UnityEngine;
using UnityEngine.InputSystem;


public class MovementControllerParanoid : MonoBehaviour
{
    public Vector2 direction;
    public int speed;
    public Rigidbody2D body;
    public float verticalSpeedFactor = 0.3f; 

    
    void Update()
    {
        if (!body || body.isKinematic)
        {
            MoveParanoid();
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

    private void MoveParanoid()
    {
        direction = new Vector2(direction.x, 0).normalized;
        // mouvement aléatoire
        direction.y  = Random.Range(-1, 2)*verticalSpeedFactor;

        var currentPosition = transform.position;
        currentPosition += Time.deltaTime * speed * (Vector3)direction;
        currentPosition.y = Mathf.Clamp(currentPosition.y, -4.5f, 4.5f);
        transform.position = currentPosition;   

    }
}
    
   




    

