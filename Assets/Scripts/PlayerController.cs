using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerDetector PlayerDetector;
    public PlayerMovementBehaviour PlayerMovementBehaviour;


    public void Initialize()
    {
        PlayerDetector.Initialize(this);
        PlayerMovementBehaviour.Initialize(this);
    }

    
}
