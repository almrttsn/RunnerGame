using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    private PlayerController _playerController;

    private int _count;

    [SerializeField] private List<GameObject> _players;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Luck" && this.tag == "Player")
        {
            _count++;
            ChangeMode();
            Debug.Log(_count);
            Destroy(other.gameObject);
            return;
        }
        if (other.tag == "Doom" && this.tag == "Player")
        {
            _count--;
            ChangeMode();
            Debug.Log(_count);
            Destroy(other.gameObject);
            return;
        }
    }
    private void ChangeMode()
    {
        foreach (var obj in _players)
        {
            obj.SetActive(false);
        }

        if (_count == -2)
        {            
            _players[0].SetActive(true);
            _playerController.PlayerEffectBehaviour.ChangeSkybox(0);
        }
        else if( _count == -1)
        {
            _players[1].SetActive(true);
            _playerController.PlayerEffectBehaviour.ChangeSkybox(1);

        }
        else if (_count == 0)
        {
            _players[2].SetActive(true);
            _playerController.PlayerEffectBehaviour.ChangeSkybox(2);

        }
        else if (_count == 1)
        {
            _players[3].SetActive(true);
            _playerController.PlayerEffectBehaviour.ChangeSkybox(3);

        }
        else if (_count == 2)
        {
            _players[4].SetActive(true);
            _playerController.PlayerEffectBehaviour.ChangeSkybox(4);

        }
    }


}
