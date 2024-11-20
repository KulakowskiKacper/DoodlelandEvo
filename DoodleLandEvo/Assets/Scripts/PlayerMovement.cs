using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerManagment playerManagment;
    [SerializeField] public float speed = 1;
    [SerializeField] private float jumpHeight;
    private bool inAir = false;

    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && !inAir)
        {
            Jump();
        }


    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) && (inAir || playerManagment.hasLegs))
        {
            MoveRight();
        }
        if (Input.GetKey(KeyCode.A) && (inAir || playerManagment.hasLegs))
        {
            MoveLeft();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        inAir = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        inAir = true;
    }

    private void MoveRight()
    {
        transform.Translate(new Vector2(speed * Time.deltaTime, 0));
    }
    private void MoveLeft()
    {
        transform.Translate(new Vector2(-speed * Time.deltaTime, 0));
    }
    private void Jump()
    {
        rb.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
    }


}
