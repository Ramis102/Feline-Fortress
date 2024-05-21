using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    
    public GameObject pivotobject;
    public float rotatespeed;
    private void FixedUpdate()
    {
        transform.RotateAround(pivotobject.transform.position, new Vector3(0, 1, 0), rotatespeed * Time.deltaTime);
    }
}
