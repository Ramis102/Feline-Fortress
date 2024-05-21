using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class exitteleport : MonoBehaviour
{
    public portalhealth portal;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("bullet"))
        {
            portal.health -= 10;
        }
    }
}
