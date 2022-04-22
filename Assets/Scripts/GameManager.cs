using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private LevelBehaviour _level;
    private LevelBehaviour _currentlyPlayingLevelBehaviour;

    private bool _lastScore;

    public InGamePanel InGamePanel;

    private void Start()
    {
        _currentlyPlayingLevelBehaviour = Instantiate(_level);
        _currentlyPlayingLevelBehaviour.Initialize(this);
        InGamePanel.Initialize(this);
    }
    public void RestartLevel()
    {
        Destroy(_currentlyPlayingLevelBehaviour.gameObject);
        _currentlyPlayingLevelBehaviour = Instantiate(_level);
        _currentlyPlayingLevelBehaviour.Initialize(this);
    }
}
