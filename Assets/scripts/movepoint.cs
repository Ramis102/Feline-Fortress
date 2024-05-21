using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepoint : MonoBehaviour
{
    public GameObject mouse;
   
        // transform.position = mouse.transform.position;
        void Update()
        {
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, this.transform.parent.rotation.z * -1.0f);
        }
    
}
