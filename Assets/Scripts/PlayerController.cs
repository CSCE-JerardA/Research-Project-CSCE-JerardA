using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        
        float horizontalVelocity = 0;
        
        // Check for 'D' key press
        if (Input.GetKey(KeyCode.D))
        {
            horizontalVelocity = moveSpeed;
        }
        // Check for 'A' key press
        else if (Input.GetKey(KeyCode.A))
        {
            horizontalVelocity = -moveSpeed;
        }

        // Apply horizontal velocity, keeping existing vertical velocity
        rb.linearVelocity = new Vector2(horizontalVelocity, rb.linearVelocity.y);


        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    
}

