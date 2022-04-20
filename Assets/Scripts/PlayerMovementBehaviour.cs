using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] float _sidewayForce;

    private PlayerController _playerController;

    private Vector3 _sidewayValue;

    private bool _isInitialized;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
        _isInitialized = true;
    }
    public void Update()
    {
        if (_isInitialized)
        {
            transform.position += new Vector3(0, 0, _speed) * Time.deltaTime;

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(-_sidewayForce, 0, 0) * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(_sidewayForce, 0, 0) * Time.deltaTime;
            }
        }
        
    }
}
