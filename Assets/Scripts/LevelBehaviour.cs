using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBehaviour : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;
    public void Initialize()
    {
        var player = Instantiate(_playerController);
        player.Initialize();
    }
}
