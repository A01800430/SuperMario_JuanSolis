using UnityEngine;

public class EnemigoController : MonoBehaviour
{
    public int speed = 1;
    public bool moveRight;

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        } else {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("PegaGoomba"))
        {
            if (moveRight)
            {
                moveRight = false;
            } else {
                moveRight = true;
            }
        }

    }

}
