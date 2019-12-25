using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(GroundChecker))]

public class Player : MonoBehaviour
{
    public TMP_Text Text;
    public int Health = 1;
    public float SpeedRotation = 10;
    public float JumpForce = 7;
    public int Money = 0;

    private Rigidbody2D _rigidbody;
    private GroundChecker _groundChecker;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _groundChecker = GetComponent<GroundChecker>();
    }

    private void Update()
    {        
        transform.Rotate(new Vector3(0, 0, -SpeedRotation) * 100 * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _groundChecker.CheckGround())
        {
            _rigidbody.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }
    }

    public void ApplyDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
            Destroy(gameObject);
    }

    public void ApplyMoney(int money)
    {
        Money += money;
        Text.text = Money.ToString();
    }
}
