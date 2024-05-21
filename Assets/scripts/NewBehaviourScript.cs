using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Camera _camera;
    public FixedJoystick joystick;
    public GameObject pivotobject;
    public float rotationspeed;
    public float flyspeed;
    public GameObject cad;
    public GameObject cheese;
    
    private void FixedUpdate()
    {
       
        cad.transform.RotateAround(pivotobject.transform.position,new Vector3(0,1,0),-1*joystick.Horizontal*rotationspeed*Time.deltaTime);
        cad.transform.position=new Vector3(cad.transform.position.x,cad.transform.position.y+joystick.Vertical*flyspeed,cad.transform.position.z);
       
    }
    private void Update()
    {
        if (cad.transform.position.y < 0)
        {
            cad.transform.position = new Vector3(cad.transform.position.x,0, cad.transform.position.z);
        }
        if (cad.transform.position.y > cheese.transform.position.y) 
        {
            cad.transform.position = new Vector3(cad.transform.position.x,cheese.transform.position.y, cad.transform.position.z);
        }
        
    }
}
