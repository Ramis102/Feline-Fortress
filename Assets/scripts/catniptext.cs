using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class catniptext : MonoBehaviour
{
    public catStats catstats;
    public Button upgradebutton;
    void Start()
    {
        
    }
    private void Update()
    {
        if(catstats.catnip<catstats.upgraderequirement)
        {
            upgradebutton.interactable = false;
        }
        else
        {
            upgradebutton.interactable = true;
        }
    }
}
