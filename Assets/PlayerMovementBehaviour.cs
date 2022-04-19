using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField] int _speed;
    [SerializeField] float _sidewayForce;
    public List<GameObject> Players = new List<GameObject> ();
    public GameObject _currentPlayer;

    public void Start()
    {
        var prop = Instantiate(Players[2], new Vector3(0, 1, 0), Quaternion.identity);
        _currentPlayer = prop;
    }
    private void Update()
    {
        _currentPlayer.transform.position += new Vector3(0, 0, _speed) * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _currentPlayer.transform.position += new Vector3(-_sidewayForce, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _currentPlayer.transform.position += new Vector3(_sidewayForce, 0, 0) * Time.deltaTime;
        }
    }
}
