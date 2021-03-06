using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<LevelBehaviour> _levels;
    private LevelBehaviour _currentlyPlayingLevelBehaviour;
    public InGamePanel InGamePanel;
    private int _currentIndex;

    private void Start()
    {
        _currentlyPlayingLevelBehaviour = Instantiate(_levels[_currentIndex]);
        _currentlyPlayingLevelBehaviour.Initialize(this);
        InGamePanel.Initialize(this);
    }
    public void RestartLevel()
    {
        Destroy(_currentlyPlayingLevelBehaviour.gameObject);
        _currentlyPlayingLevelBehaviour = Instantiate(_levels[_currentIndex]);
        _currentlyPlayingLevelBehaviour.Initialize(this);
        InGamePanel.DisableShopPanel();
        InGamePanel.DisableMissionFailurePanel();
        InGamePanel.DisableGameOverPanel();
    }

    public void LoadNextLevel()
    {
        _currentIndex++;
        if(_currentIndex < 3)
        {
            Destroy(_currentlyPlayingLevelBehaviour.gameObject);
            _currentlyPlayingLevelBehaviour = Instantiate(_levels[_currentIndex]);
            _currentlyPlayingLevelBehaviour.Initialize(this);
            InGamePanel.DisableShopPanel();
            InGamePanel.DisableMissionSuccessfulPanel();
        }
        else
        {
            Destroy(_currentlyPlayingLevelBehaviour.gameObject);
            _currentlyPlayingLevelBehaviour = Instantiate(_levels[0]);
            _currentlyPlayingLevelBehaviour.Initialize(this);
            InGamePanel.Initialize(this);
        }
        
    }


}
