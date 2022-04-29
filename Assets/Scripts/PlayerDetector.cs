using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDetector : MonoBehaviour
{
    private PlayerController _playerController;

    private int _count;

    [SerializeField] private List<GameObject> _players;
    [SerializeField] private float _happinessAmountFactor;

    [SerializeField] Image HappinessBar;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
    }

    private void Update()
    {
        if(HappinessBar.fillAmount < 0.33)
        {
            HappinessBar.color = Color.red;
        }
        else if(HappinessBar.fillAmount > 0.33 && HappinessBar.fillAmount < 0.66)
        {
            HappinessBar.color = Color.yellow;
        }
        else if(HappinessBar.fillAmount > 0.66)
        {
            HappinessBar.color = Color.green;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Luck" && this.tag == "Player")
        {
            _count++;
            ChangeMode();
            Debug.Log(_count);
            other.gameObject.GetComponentInChildren<ParticleSystem>().Play();
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            HappinessBar.fillAmount += _happinessAmountFactor / 10;
        }
        if (other.tag == "Doom" && this.tag == "Player")
        {
            _count--;
            ChangeMode();
            Debug.Log(_count);
            other.gameObject.GetComponentInChildren<ParticleSystem>().Play();
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            HappinessBar.fillAmount -= _happinessAmountFactor / 10;
        }
        if (other.tag == "Finish" && this.tag == "Player")
        {
            EvaluateScoreResult();
            Debug.Log("End trigger is triggered");
        }
    }
    private void ChangeMode()
    {
        _count = Mathf.Clamp(_count, -2, 2);

        foreach (var obj in _players)
        {
            obj.SetActive(false);
        }

        if (_count == -2)
        {            
            //_players[0].SetActive(true);
            _playerController.PlayerEffectBehaviour.ChangeSkybox(0);
        }
        else if( _count == -1)
        {
            //_players[1].SetActive(true);
            _playerController.PlayerEffectBehaviour.ChangeSkybox(1);

        }
        else if (_count == 0)
        {
            //_players[2].SetActive(true);
            _playerController.PlayerEffectBehaviour.ChangeSkybox(2);

        }
        else if (_count == 1)
        {
            //_players[3].SetActive(true);
            _playerController.PlayerEffectBehaviour.ChangeSkybox(3);

        }
        else if (_count == 2)
        {
            //_players[4].SetActive(true);
            _playerController.PlayerEffectBehaviour.ChangeSkybox(4);

        }
    }

    public void EvaluateScoreResult()
    {
        if(_count < 1)
        {
            Debug.Log("Mission Failure");
            _playerController.LevelBehaviour._gameManager.InGamePanel.EnableShopPanel();
            _playerController.LevelBehaviour._gameManager.InGamePanel.EnableMissionFailurePanel();
        }
        else
        {
            Debug.Log("Mission Success");
            _playerController.LevelBehaviour._gameManager.InGamePanel.EnableShopPanel();
            _playerController.LevelBehaviour._gameManager.InGamePanel.EnableMissionSuccessfulPanel();
        }
    }


}
