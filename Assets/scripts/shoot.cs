using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawnPoint;
    public float fireRate;
    float timer;
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= fireRate)
        {
            timer = 0;
            GameObject bull = Instantiate(bullet,
spawnPoint.transform.position, spawnPoint.transform.rotation);
            bull.SetActive(true);

        }
    }
}