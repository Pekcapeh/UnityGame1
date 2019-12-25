using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public GameObject Point;
    public float Radius;
    public LayerMask WhatIsGround;

    public bool CheckGround()
    {
        return Physics2D.OverlapCircle(Point.transform.position, Radius, WhatIsGround);
    }
}
