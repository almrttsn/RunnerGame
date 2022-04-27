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

    [SerializeField] Image HappinesBar;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
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
            var _currentFillAmount = HappinesBar.fillAmount;
            HappinesBar.fillAmount = _currentFillAmount + (HappinesBar.fillAmount * _happinessAmountFactor / 10);
        }
        if (other.tag == "Doom" && this.tag == "Player")
        {
            _count--;
            ChangeMode();
            Debug.Log(_count);
            other.gameObject.GetComponentInChildren<ParticleSystem>().Play();
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            var _currentFillAmount = HappinesBar.fillAmount;
            HappinesBar.fillAmount = _currentFillAmount - (HappinesBar.fillAmount * _happinessAmountFactor / 10);
        }
        if(other.tag == "Finish" && this.tag == "Player")
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
            _players[0].SetActive(true);
            _playerController.PlayerEffectBehaviour.ChangeSkybox(0);
        }
        else if( _count == -1)
        {
            _players[1].SetActive(true);
            _playerController.PlayerEffectBehaviour.ChangeSkybox(1);

        }
        else if (_count == 0)
        {
            _players[2].SetActive(true);
            _playerController.PlayerEffectBehaviour.ChangeSkybox(2);

        }
        else if (_count == 1)
        {
            _players[3].SetActive(true);
            _playerController.PlayerEffectBehaviour.ChangeSkybox(3);

        }
        else if (_count == 2)
        {
            _players[4].SetActive(true);
            _playerController.PlayerEffectBehaviour.ChangeSkybox(4);

        }
    }

    public void EvaluateScoreResult()
    {
        if(_count < 1)
        {
            Debug.Log("Mission Failure");
            _playerController._levelBehaviour._gameManager.InGamePanel.EnableShopPanel();
            _playerController._levelBehaviour._gameManager.InGamePanel.EnableMissionFailurePanel();
        }
        else
        {
            Debug.Log("Mission Success");
            _playerController._levelBehaviour._gameManager.InGamePanel.EnableShopPanel();
            _playerController._levelBehaviour._gameManager.InGamePanel.EnableMissionSuccessfulPanel();
        }
    }


}
