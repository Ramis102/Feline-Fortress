using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatearound : MonoBehaviour
{
    public CinemachineVirtualCamera _camera;
    public GameObject pivotobject;
    public float rotatespeed;
    void Start()
    {
        _camera = GetComponent<CinemachineVirtualCamera>();
    }

    
    private void FixedUpdate()
    {
        _camera.transform.RotateAround(pivotobject.transform.position, new Vector3(0, 1, 0), rotatespeed * Time.deltaTime);
    }
    
        
    
}
