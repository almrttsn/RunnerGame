using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;

    public List<GameObject> Players = new List<GameObject>();

    public GameObject _initializedDesiredObject;

    public void Initialize()
    {
        var prop = Instantiate(Players[2], new Vector3(0, 1, 0), Quaternion.identity);
        _initializedDesiredObject = prop;
    }


}
