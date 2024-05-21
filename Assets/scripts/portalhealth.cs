using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalhealth : MonoBehaviour
{
    public int health;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("bullet"))
        {
            health -= 10;
        }       
    }  

    private void Update()
    {
        if(health <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }

}
