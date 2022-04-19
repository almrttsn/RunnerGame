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
        }
        if (other.tag == "Doom" && this.tag == "Player")
        {
            _count--;
            ChangeMode();
            Debug.Log(_count);
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
        }
        else if( _count == -1)
        {
            _players[1].SetActive(true);

        }
        else if (_count == 0)
        {
            _players[2].SetActive(true);

        }
        else if (_count == 1)
        {
            _players[3].SetActive(true);

        }
        else if (_count == 2)
        {
            _players[4].SetActive(true);

        }
    }


}
