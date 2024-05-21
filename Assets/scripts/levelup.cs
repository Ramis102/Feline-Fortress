using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelup : MonoBehaviour
{
    public GameObject tower;
    public GameObject cheese;
    public catStats cat;
    public Transform spawnposition;
    public float length;
    public GameObject particles;
    public float height=3.5f;
    
    public void LevelUp()
    {
        Vector3 position= spawnposition.position;
        Quaternion rotation = spawnposition.rotation;
        int leveluprequirement = cat.getupgraderequirements();
        if(cat.CanLevelUp()==true)
        {
            cat.requirementincrease();
            Instantiate(tower, position,rotation);   
            cheese.transform.SetPositionAndRotation(cheese.transform.position + new Vector3(0, length, 0), cheese.transform.rotation);
            increaseheight();
            cat.catnip -= leveluprequirement;
            particles.transform.localScale += new Vector3(1,3.5f, 1);
            GameObject particle= Instantiate(particles,tower.transform.position,tower.transform.rotation);
            Debug.Log(particle.transform.localScale.y);
            Destroy(particle,3.0f);
        }
    }
    void increaseheight()
    {
        spawnposition.SetPositionAndRotation(spawnposition.position + new Vector3(0, length, 0), spawnposition.rotation*Quaternion.Euler(0,-25,0));
    }

}
