using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public float acceleration = 20f; 
    public float deceleration = 20f;

    public Sprite[] skins;
    public SpriteRenderer sr;
    public int index;

    private Vector2 moveInput; 
    private Rigidbody2D rb; 
    private float currentSpeed;

    public PlayerShoot ps;

    public float[] FireRate;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       // sr = GetComponent<SpriteRenderer>();
        sr.sprite = skins[0];
        ps = GetComponent<PlayerShoot>();
    }

    void Update()
    {
        // Get the input from the player
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        
        if (Input.GetMouseButtonDown(1))
        {
            index++;

            if (index >= skins.Length)
            {
                index = 0;


            }

            sr.sprite = skins[index];
            ps.fireRate = FireRate[index];

        }
    }

    void FixedUpdate()
    {
        
        
        
        
        // Calculate the current speed of the player
        if (moveInput.magnitude > 0)
        {
            currentSpeed = Mathf.MoveTowards(currentSpeed, moveSpeed, acceleration * Time.fixedDeltaTime);
        }
        else
        {
            currentSpeed = Mathf.MoveTowards(currentSpeed, 0, deceleration * Time.fixedDeltaTime);
        }

        // Move the player
        rb.velocity = moveInput * currentSpeed;
    }




}

