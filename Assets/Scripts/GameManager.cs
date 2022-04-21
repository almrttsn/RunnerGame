using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private LevelBehaviour _level;
    private LevelBehaviour _currentlyPlayingLevelBehaviour;

    private void Start()
    {
        _currentlyPlayingLevelBehaviour = Instantiate(_level);
        _currentlyPlayingLevelBehaviour.Initialize();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(_currentlyPlayingLevelBehaviour.gameObject);
            _currentlyPlayingLevelBehaviour = Instantiate(_level);
            _currentlyPlayingLevelBehaviour.Initialize();
        }
    }
}
