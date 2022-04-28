using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerDetector PlayerDetector;
    public PlayerMovementBehaviour PlayerMovementBehaviour;
    public PlayerEffectBehaviour PlayerEffectBehaviour;
    public LevelBehaviour LevelBehaviour;
    public PlayerAnimationBehaviour PlayerAnimationBehaviour;

    public void Initialize(LevelBehaviour levelBehaviour)
    {
        LevelBehaviour = levelBehaviour;
        PlayerDetector.Initialize(this);
        PlayerMovementBehaviour.Initialize(this);
        PlayerEffectBehaviour.Initialize(this);
        PlayerAnimationBehaviour.Initialize(this);
    }

    
}
