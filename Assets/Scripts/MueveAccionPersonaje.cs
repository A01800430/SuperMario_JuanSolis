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
    }

    void FixedUpdate()
    {
        Vector2 move = moveAction.ReadValue<Vector2>();
        transform.position = (Vector2)transform.position + move * SPEED * Time.deltaTime;
    }
}