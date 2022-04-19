using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    //[SerializeField] private PlayerController _playerController;

    [SerializeField] float _speed;
    [SerializeField] float _sidewayForce;

    public GameObject _objectToBeMoved;

    private PlayerController _playerController;

    private bool _isInitialized;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
        _objectToBeMoved = _playerController._currentPlayer;
        _isInitialized = true;
    }
    public void Update()
    {
        if (_isInitialized)
        {
            _objectToBeMoved.transform.position += new Vector3(0, 0, _speed) * Time.deltaTime;

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                _objectToBeMoved.transform.position += new Vector3(-_sidewayForce, 0, 0) * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                _objectToBeMoved.transform.position += new Vector3(_sidewayForce, 0, 0) * Time.deltaTime;
            }
        }
        
    }
}
