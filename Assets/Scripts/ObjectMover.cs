﻿using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    private float _speed = 13;

    private void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }
}
