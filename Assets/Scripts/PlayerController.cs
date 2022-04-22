using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerDetector PlayerDetector;
    public PlayerMovementBehaviour PlayerMovementBehaviour;
    public PlayerEffectBehaviour PlayerEffectBehaviour;
    public LevelBehaviour _levelBehaviour;

    public void Initialize(LevelBehaviour levelBehaviour)
    {
        _levelBehaviour = levelBehaviour;
        PlayerDetector.Initialize(this);
        PlayerMovementBehaviour.Initialize(this);
        PlayerEffectBehaviour.Initialize(this);
    }

    
}
