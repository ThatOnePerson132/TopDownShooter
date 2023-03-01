using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f;
    public float patrolDistance = 5f;

    private Rigidbody2D rb;
    private bool isMovingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        Vector2 movement = Vector2.right * speed * Time.deltaTime;

        // Move the enemy
        if (isMovingRight && Mathf.Abs(rb.position.x - transform.position.x) >= patrolDistance)
        {
            isMovingRight = false;
        }
        else if (!isMovingRight && Mathf.Abs(rb.position.x - transform.position.x) >= patrolDistance)
        {
            isMovingRight = true;
        }

        if (isMovingRight)
        {
            rb.MovePosition(rb.position + movement);
        }
        else
        {
            rb.MovePosition(rb.position - movement);
        }
    }
}



