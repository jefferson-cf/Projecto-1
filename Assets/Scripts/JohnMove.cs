using UnityEngine;

public class JohnMove : MonoBehaviour

{
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        Rigidbody2D.linearVelocity = new Vector2(Horizontal, Rigidbody2D.linearVelocity.y);
    }
}
