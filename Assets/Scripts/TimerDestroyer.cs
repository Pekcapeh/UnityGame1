using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestroyer : MonoBehaviour
{
    private float _timeLife = 5;

    private void Update()
    {
        _timeLife -= Time.deltaTime;

        if (_timeLife <= 0)
            Destroy(gameObject);
    }
}
