using UnityEngine;

public class MuevePersonaje : MonoBehaviour
{
    
    // Velocidades
    public float velocidadX;

    [SerializeField] //Permite al editor de Unity acceder a la variable

    private float movimientoX;
    private Rigidbody2D rb;
    private bool facingRight = true;
    public Animator animator;
    public int jumpPower = 1;
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius = 0.6f;
    public LayerMask whatIsGround;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Inicializo el Rigidbody y el Animator
        rb = GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate()
    {
        movimientoX = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(movimientoX));

    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        animator.SetBool("IsGrounded", isGrounded);
        // Condiciones para voltear al personaje
        if (movimientoX < 0.0f && facingRight)
        {
            FlipPlayer();
        }

        if (movimientoX > 0.0f && !facingRight)
        {
            FlipPlayer();
        }
        // Condiciones para el salto
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            Jump();
        }
    }

    // Voltear al personaje segun se mueva derecha o izquierda
    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 playerScale = gameObject.transform.localScale;
        playerScale.x *= -1;
        transform.localScale = playerScale;
    }

    // Metodo de salto
    void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0); 
    }


    //Dibujar el overlapcircle en la escena para verificar si esta en el suelo
    void OnDrawGizmos()
    {
        if(feetPos != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(feetPos.position, checkRadius);
        }
    }


}
