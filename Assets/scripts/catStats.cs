
using System;
using TMPro;
using UnityEngine;

public class catStats : MonoBehaviour
{
    public int catnip;
    public float health;
    public float maxHealth;
    public GameObject hitparticles;
    public healthbar healthbar;
    public int upgraderequirement;
    public int kills;
    public bool CanLevelUp()
    {
        if(catnip>=upgraderequirement)
        {
            return true;
        }
        else return false;
    }
    private void Start()
    {
        catnip = 0;
        maxHealth = 200;
        upgraderequirement = 50;
    }
    public void requirementincrease()
    {
        upgraderequirement += 50;
    }
    public void damage()
    {
        this.health -= 10;
        Debug.Log("damage");
        hitparticles.SetActive(true);
        Invoke("deactivate",1.0f);
        healthbar.decreaseSize();
        if(health<=0)
        {
            Actions.gamelost();
        }
    }
    private void deactivate()
    {
        hitparticles.SetActive(false);
    }
    public void addcatnip()
    {
        catnip += 10;
    }
    public int getupgraderequirements()
    {
        return upgraderequirement;
    }
    public void increasekills()
    {
        kills++;
    }
}
