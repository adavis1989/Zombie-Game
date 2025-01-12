using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int _maxHealth;
    [SerializeField]
    private int _playerHealth;
    private NavMeshAgent _navMesh;
    private Vector3 _target;

    // Start is called before the first frame update
    void Start()
    {
        _playerHealth = _maxHealth;
        _navMesh= GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(ray, out hitInfo))
            {
                Debug.Log("Hit :" + hitInfo.point);
                _navMesh.SetDestination(hitInfo.point);
                _target= hitInfo.point;
            }
        }
    }
}
