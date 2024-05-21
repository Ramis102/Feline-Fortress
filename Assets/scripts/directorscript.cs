using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class directorscript : MonoBehaviour
{
    public Animator animator;
    public CinemachineVirtualCamera _camera;
    private void Start()
    {
        animator.Play("homeScreencamera");
    }
    private void OnEnable()
    {
        Actions.startaction += SwitchStates;
    }
    private void OnDisable()
    {
        Actions.startaction -= SwitchStates;
    }
    private void SwitchStates()
    {
        animator.Play("GameScreenCamera");
    }


}
