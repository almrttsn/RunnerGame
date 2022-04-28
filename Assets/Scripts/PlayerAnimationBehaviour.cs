using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationBehaviour : MonoBehaviour
{
    [SerializeField] Animator _playerAnimator;


    public void SetRunningAnimation()
    {
        _playerAnimator.SetBool("Run", true);
    }

    public void Initialize(PlayerController playerController)
    {

    }
}
