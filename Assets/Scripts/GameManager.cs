using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<LevelBehaviour> _levels;
    //[SerializeField] private LevelBehaviour _level;
    private LevelBehaviour _currentlyPlayingLevelBehaviour;
    private LevelBehaviour _nextLevel;

    private bool _lastScore;

    public InGamePanel InGamePanel;

    private void Start()
    {
        _currentlyPlayingLevelBehaviour = Instantiate(_levels[0]);
        _currentlyPlayingLevelBehaviour.Initialize(this);
        InGamePanel.Initialize(this);
    }
    public void RestartLevel()
    {
        Destroy(_currentlyPlayingLevelBehaviour.gameObject);
        _currentlyPlayingLevelBehaviour = Instantiate(_levels[0]);
        _currentlyPlayingLevelBehaviour.Initialize(this);
    }

    public void LoadNextLevel()
    {
        for(int i = 1; i < _levels.Count; i++)
        {
            Destroy(_currentlyPlayingLevelBehaviour.gameObject);
            _nextLevel = Instantiate(_levels[i]);
            _nextLevel.Initialize(this);
            return;
        }
    }


}
