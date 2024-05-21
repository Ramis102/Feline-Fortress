using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class moveto : MonoBehaviour
{
    public int health = 30;
    public GameObject particles;
    public GameObject currency;
    public catStats catStats;
    public GameObject cad;
    public mousespawner mousespawner;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "bullet" || other.gameObject.name == "bullet(clone)")
        {
            this.health -= 10;
        }
    }

    void destroymouse()
    {
        Vector3 pos=this.gameObject.transform.position;
        Vector3 direction = (cad.transform.position - this.gameObject.transform.position).normalized;
        GameObject particle = Instantiate(particles, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject); 
        Destroy(particle, 0.5f);
        GameObject curr=Instantiate(currency, pos, Quaternion.LookRotation(direction));
        Destroy(curr, 1.5f);
        catStats.addcatnip();
        catStats.increasekills();
    }
    
    private void FixedUpdate()
    {
                 
        if (this.health <= 0)
        {
            if (this.gameObject.tag == "mouse" && this.gameObject.name != "mouse")
            {
                WaveCreator scr = mousespawner.GetComponent<WaveCreator>();
                scr.totalKills++;
                scr.kills++;
                destroymouse();  
            }
        }
       
    }
    

}




    



