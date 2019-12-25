using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Damage = 1;
    public float Speed = 5;

    void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Player>().ApplyDamage(Damage);
            Destroy(gameObject);
        }
    }
}
