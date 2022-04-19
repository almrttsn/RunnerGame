using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    [SerializeField] GameObject _parentPrefab;

    public List<GameObject> Players = new List<GameObject>();

    public GameObject _initializedDesiredObjects;

    private PlayerController _playerController;

    private int _count;

    public void Initialize(PlayerController playerController)
    {
        {
            _playerController = playerController;
            var prop = Instantiate(_parentPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            _initializedDesiredObjects = prop;

        }
    }

    private void Start()
    {
        _parentPrefab.transform.GetChild(2).gameObject.SetActive(true);

    }

    private void Update()
    {
        ChangeMode();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Luck" && this.tag == "Player")
        {
            _count++;
            Debug.Log(_count);
        }
        if (other.tag == "Doom" && this.tag == "Player")
        {
            _count--;
            Debug.Log(_count);
        }
    }
    private void ChangeMode()
    {
        if (_count == -2)
        {
            var _current = _parentPrefab.transform.GetChild(1);
            _current.gameObject.SetActive(false);

            var _previous = _parentPrefab.transform.GetChild(0);
            _previous.gameObject.SetActive(true);

        }
        if (_count == -1)
        {
            var _current = _parentPrefab.transform.GetChild(2);
            _current.gameObject.SetActive(false);

            var _previous = _parentPrefab.transform.GetChild(1);
            _previous.gameObject.SetActive(true);
        }
        if (_count == 0)
        {
            var _current = _parentPrefab.transform.GetChild(1);
            _current.gameObject.SetActive(false);

            var _next = _parentPrefab.transform.GetChild(2);
            _next.gameObject.SetActive(true);
        }
        if (_count == 1)
        {
            var _current = _parentPrefab.transform.GetChild(2);
            _current.gameObject.SetActive(false);

            var _next = _parentPrefab.transform.GetChild(3);
            _next.gameObject.SetActive(true);
        }
        if (_count == 2)
        {
            var _current = _parentPrefab.transform.GetChild(3);
            _current.gameObject.SetActive(false);

            var _next = _parentPrefab.transform.GetChild(4);
            _next.gameObject.SetActive(true);
        }
    }


}
