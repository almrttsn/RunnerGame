using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InGamePanel : MonoBehaviour
{
    [SerializeField] private GameObject _shopPanel;    

    private GameManager _gameManager;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
        _shopPanel = this.gameObject.transform.GetChild(0).gameObject;
        DisableShopPanel();
    }

    public void DisableShopPanel()
    {
        _shopPanel.SetActive(false);
    }

    public void EnableShopPanel()
    {
        _shopPanel.SetActive(true);
    }

    public void EnableMissionSuccessfulPanel()
    {
        _shopPanel.gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void EnableMissionFailurePanel()
    {
        _shopPanel.gameObject.transform.GetChild(1).gameObject.SetActive(true);
    }

    public void DisableMissionSuccessfulPanel()
    {
        _shopPanel.gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    public void DisableMissionFailurePanel()
    {
        _shopPanel.gameObject.transform.GetChild(1).gameObject.SetActive(false);
    }

    public void EnableGameOverPanel()
    {
        EnableShopPanel();
        _shopPanel.gameObject.transform.GetChild(2).gameObject.SetActive(true);
    }

    public void DisableGameOverPanel()
    {
        _shopPanel.gameObject.transform.GetChild(2).gameObject.SetActive(false);
    }
}
