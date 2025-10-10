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

    void Update() // We'll handle everything in Update for this test
    {
        // --- 1. Horizontal Movement Test (Checks raw key press) ---
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


        // --- 2. Jump Test (No Ground Check) ---
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    // Remove FixedUpdate() entirely for this test.
}
