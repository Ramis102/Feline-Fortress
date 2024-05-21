using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class currencyscript : MonoBehaviour
{
    public GameObject cad;
    public Rigidbody coins;
    private void Start()
    {
        cad = GameObject.FindGameObjectWithTag("Cad");
        coins=GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Vector3 shootDirection = (cad.gameObject.transform.position - coins.gameObject.transform.position).normalized;
        coins.AddForce(shootDirection, ForceMode.Impulse);
        coins.transform.right = shootDirection;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cad" || other.gameObject.tag == "Cad")
        {
            Destroy(this.gameObject);
        }
    }
}
