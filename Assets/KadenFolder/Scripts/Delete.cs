using UnityEngine;

public class Delete : MonoBehaviour
{
    public float deleteTime = 30f; // The time in seconds after which the object should be deleted.

    void Start()
    {
        // Call the Destroy method after deleteTime seconds.
        Destroy(gameObject, deleteTime);
    }
}

