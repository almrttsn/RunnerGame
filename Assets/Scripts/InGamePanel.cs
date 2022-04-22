using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InGamePanel : MonoBehaviour
{
    [SerializeField] private GameObject _shopPanel;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _nextLevelButton;
    [SerializeField] private Text _failureText;
    [SerializeField] private Text _successfulText;

    private GameManager _gameManager;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
        Debug.Log("In game panel script is active");
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

    public void EnableMissionFailurePanel()
    {
        //_restartButton.enabled = true;
        _shopPanel.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        //_failureText.enabled = true;
        _shopPanel.gameObject.transform.GetChild(2).gameObject.SetActive(true);

    }

    public void EnableMissionSuccessfulPanel()
    {
        //_nextLevelButton.enabled = true;
        _shopPanel.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        //_successfulText.enabled = true;
        _shopPanel.gameObject.transform.GetChild(3).gameObject.SetActive(true);

    }




}
