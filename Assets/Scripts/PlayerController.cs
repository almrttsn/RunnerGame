using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerDetector PlayerDetector;
    public PlayerMovementBehaviour PlayerMovementBehaviour;

    public GameObject _currentPlayer;

    public void Start()
    {
        PlayerDetector.Initialize(this);
        _currentPlayer = PlayerDetector._initializedDesiredObjects;
        PlayerMovementBehaviour.Initialize(this);
    }

    
}
