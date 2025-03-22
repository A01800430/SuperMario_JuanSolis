using UnityEngine;
using UnityEngine.InputSystem;

public class MueveInputAction : MonoBehaviour
{
    [SerializeField]
    private InputAction moveAction; 

    private const float SPEED = 8.0f; 
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveAction.Enable();
        rb.gravityScale = 20;
    }

    void FixedUpdate()
    {
        Vector2 move = moveAction.ReadValue<Vector2>();
        rb.MovePosition(rb.position + move * SPEED * Time.fixedDeltaTime);
    }
}