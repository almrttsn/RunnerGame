using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationBehaviour : MonoBehaviour
{
    [SerializeField] Animator _playerAnimator;

    private PlayerController _playerController;

    public bool _isPlaying;
    
    public void SetRunningAnimation()
    {
        if(_isPlaying == true)
        {
            Debug.Log("running");
            _playerAnimator.SetBool("Run", true);
        }
    }

    public void SetFallingAnimation()
    {
        if(_isPlaying == false)
        {
            Debug.Log("falling");
            _playerAnimator.SetBool("Fall", true);
        }        
    }

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
    }
}
