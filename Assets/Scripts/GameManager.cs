using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<LevelBehaviour> _levels;
    private LevelBehaviour _startingLevelBehaviour;
    private LevelBehaviour _currentlyPlayingLevelBehaviour;
    private LevelBehaviour _nextlyPlayingLeveBehaviour;
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
        _currentlyPlayingLevelBehaviour = Instantiate(_levels[]);
        _currentlyPlayingLevelBehaviour.Initialize(this);
        InGamePanel.DisableShopPanel();
    }

    public void LoadNextLevel()
    {
        Destroy(_currentlyPlayingLevelBehaviour.gameObject);
        _nextlyPlayingLeveBehaviour = Instantiate(_levels[]);
        _nextlyPlayingLeveBehaviour.Initialize(this);
        InGamePanel.DisableShopPanel();
    }


}
