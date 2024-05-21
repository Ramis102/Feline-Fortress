using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float shootInterval = 2.0f;
    bool shoot=false;
    public Transform player;
    private float lastShootTime;

    private void Start()
    {
        
        lastShootTime = Time.time;
    }

    private void Update()
    {
        if (Time.time - lastShootTime >= shootInterval && shoot==true)
        {
            Shoot();
            lastShootTime = Time.time;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cad"))
        {
            shoot= true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cad"))
        {
            shoot = false;  
        }

    }

private void Shoot()
    {
       Debug.Log("shot");
        Vector3 shootDirection = (player.position - firePoint.position).normalized;
       GameObject bull= Instantiate(bulletPrefab, firePoint.position, Quaternion.LookRotation(shootDirection));
        bull.SetActive(true);
    }
}