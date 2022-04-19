using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerController _startingPlayerPrefab;

    private void Start()
    {
        var player = Instantiate(_startingPlayerPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        player.Initialize();
    }


}
