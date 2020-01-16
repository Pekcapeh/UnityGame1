using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private GameObject _point;
    [SerializeField] private LayerMask _whatIsGround;

    private float _radius = 0.7f;
    
    public bool CheckGround()
    {
        return Physics2D.OverlapCircle(_point.transform.position, _radius, _whatIsGround);
    }
}
