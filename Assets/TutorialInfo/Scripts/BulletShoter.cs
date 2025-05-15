using UnityEngine;

public class BulletShoter : MonoBehaviour
{
    public GameObject bulletPrefab;  // Prefab da bala
    public Transform firePoint;      // Ponto de disparo
    public float bulletSpeed = 100f; // Velocidade da bala

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = firePoint.forward * bulletSpeed;
        }
    }
}
