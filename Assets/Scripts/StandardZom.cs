using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardZom : EnemyClass
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, _player.position);

        if (distanceToPlayer <= _maxChaseDistance)
        {
            Vector3 direction = (_player.position - transform.position).normalized;

            transform.position += direction * _speed * Time.deltaTime;

            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * _speed);
        }

    }
}
