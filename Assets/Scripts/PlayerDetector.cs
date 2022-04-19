using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{

    public List<GameObject> Players = new List<GameObject>();

    public GameObject _initializedDesiredObjects;

    private PlayerController _playerController;

    private int _count;
    public void Initialize(PlayerController playerController)
    {
        for(int i = 0; i <Players.Count; i++)
        {
            _playerController = playerController;
            var prop = Instantiate(Players[i], new Vector3(0, 0, 0), Quaternion.identity);
            _initializedDesiredObjects = prop;
        }        
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


}
