using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InGamePanel : MonoBehaviour
{
    [SerializeField] List<TextMeshPro> texts;
    [SerializeField] List<Button> buttons;

    private GameManager _gameManager;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
        Debug.Log("In game panel script is active");
        DisableInGamePanel();
    }

    public void DisableInGamePanel()
    {
        this.gameObject.SetActive(false);
    }

    public void EnableInGamePanel()
    {
        this.gameObject.SetActive(true);
    }

    public void EnableMissionFailurePanel()
    {
        buttons[0].enabled = true;
        //texts[0].enabled = true;
    }

    public void EnableMissionSuccessfulPanel()
    {
        buttons[1].enabled = true;
        //texts[1].enabled = true;
    }




}
