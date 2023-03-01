using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectilePrefab; 
    public Transform projectileSpawnPoint; 
    public float projectileSpeed = 10f; 
    public float fireRate = 0.5f; 

    private float nextFireTime = 0f; 

    void Update()
    {
       
        if (Input.GetMouseButton(0) && Time.time > nextFireTime)
        {
            
            nextFireTime = Time.time + fireRate;

            
            GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);

            
            Rigidbody2D projectileRigidbody = projectile.GetComponent<Rigidbody2D>();
            projectileRigidbody.velocity = projectileSpawnPoint.right * projectileSpeed;
        }
    }
}

