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

    private void Update()
    {
        _parentPrefab.transform.GetChild(2).gameObject.SetActive(true);
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

    //private void ChangeThePlayer()
    //{
    //    if(_count > 2)
    //    {
    //        var a =_parentPrefab.transform.GetChild(3);
    //        a.gameObject.SetActive(true);
    //    }
    //}


}
