using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEffectBehaviour : MonoBehaviour
{

    private PlayerController _playerController;

    private int _desiredSkyboxNumber;

    [SerializeField] List<Material> _skyboxMaterials;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
    }

    public void ChangeSkybox(int _desiredSkyboxNumber)
    {
        RenderSettings.skybox = _skyboxMaterials[_desiredSkyboxNumber];
    }

}
