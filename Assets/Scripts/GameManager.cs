using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private LevelBehaviour _level;

    private void Start()
    {
        //var player = Instantiate(_startingPlayerPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        //player.Initialize();

        var currentLevel = Instantiate(_level);
        currentLevel.Initialize();
    }
}
