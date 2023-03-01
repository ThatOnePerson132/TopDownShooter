using UnityEngine;

public class MouseRotate : MonoBehaviour
{
    public float rotationSpeed = 10f; // The speed at which the player rotates.

    private Vector2 mousePosition; // The position of the mouse cursor.
    private Transform playerTransform; // The transform component of the player.

    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    void Update()
    {
        // Get the position of the mouse cursor.
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Calculate the direction to the mouse cursor.
        Vector2 direction = mousePosition - (Vector2)playerTransform.position;

        // Calculate the angle of the direction.
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rotate the player toward the mouse cursor.
        playerTransform.rotation = Quaternion.Slerp(playerTransform.rotation, Quaternion.AngleAxis(angle, Vector3.forward), rotationSpeed * Time.deltaTime);
    }
}

