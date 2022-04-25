using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<LevelBehaviour> _levels;
    [SerializeField] LevelBehaviour _currentlyPlayingLevelBehaviour;
    public InGamePanel InGamePanel;
    private int _currentIndex;

    private void Start()
    {
        _currentlyPlayingLevelBehaviour = Instantiate(_currentlyPlayingLevelBehaviour);
        _currentlyPlayingLevelBehaviour.Initialize(this);
        InGamePanel.Initialize(this);
    }
    public void RestartLevel()
    {
        Destroy(_currentlyPlayingLevelBehaviour.gameObject);
        _currentlyPlayingLevelBehaviour = Instantiate(_currentlyPlayingLevelBehaviour);
        _currentlyPlayingLevelBehaviour.Initialize(this);
        InGamePanel.DisableShopPanel();
    }

    public void LoadNextLevel()
    {
        Destroy(_currentlyPlayingLevelBehaviour.gameObject);        
        InGamePanel.DisableShopPanel();
    }


}
