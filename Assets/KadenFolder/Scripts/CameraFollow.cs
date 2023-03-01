using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;        // the target object the camera will follow
    public float smoothing = 5f;    // the speed at which the camera follows the target

    private Vector3 offset;         // the initial offset between the camera and the target

    private void Start()
    {
        offset = transform.position - target.position; // calculate the initial offset between the camera and the target
    }

    private void LateUpdate()
    {
        Vector3 targetPosition = target.position + offset; // calculate the target position for the camera
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime); // smoothly move the camera towards the target position
    }
}

