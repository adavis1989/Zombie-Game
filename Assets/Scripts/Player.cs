using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int _maxHealth;
    [SerializeField]
    private int _playerHealth;


    // Start is called before the first frame update
    void Start()
    {
        _playerHealth = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
