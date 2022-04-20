using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEffectBehaviour : MonoBehaviour
{

    private PlayerController _playerController;

    private int _desiredSkyboxNumber;

    [SerializeField] List<Material> _skyboxMaterials;
    [SerializeField] List<ParticleSystem> _particles;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
    }

    public void ChangeSkybox(int _desiredSkyboxNumber)
    {
        RenderSettings.skybox = _skyboxMaterials[_desiredSkyboxNumber];
    }

    public void CollectLuckParticle()
    {
        _particles[0].Play();
    }

    public void CollectDoomParticle()
    {
        _particles[1].Play();
    }

}
