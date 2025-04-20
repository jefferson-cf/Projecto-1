using UnityEngine;

public class JohnMove : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    private bool Grounded;

    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        if (Physics2D.Raycast(transform.position, Vector3.down, 0.2f))
        {
            Grounded = true;
        }
        else Grounded = false;

        if (Input.GetKeyDown(KeyCode.Space) && Grounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }

    private void FixedUpdate()
    {
        Rigidbody2D.linearVelocity = new Vector2(Horizontal, Rigidbody2D.linearVelocity.y);
    }
}
