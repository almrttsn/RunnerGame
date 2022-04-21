using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerDetector PlayerDetector;
    public PlayerMovementBehaviour PlayerMovementBehaviour;
    public PlayerEffectBehaviour PlayerEffectBehaviour;

    public void Initialize()
    {
        PlayerDetector.Initialize(this);
        PlayerMovementBehaviour.Initialize(this);
        PlayerEffectBehaviour.Initialize(this);
    }

    
}
