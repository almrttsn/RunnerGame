using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBehaviour : MonoBehaviour
{
    [SerializeField] private PlayerController _playerPrefab;
    [SerializeField] private PlayerController _playerInLevel;
    public void Initialize()
    {
        //var player = Instantiate(_playerController);
        //player.Initialize();

        //_playerPrefab.Initialize();
        _playerInLevel.Initialize();

    }
}
