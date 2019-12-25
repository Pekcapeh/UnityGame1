using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int Money = 1;
    public int Speed = 5;
        
    void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Player>().ApplyMoney(Money);
            Destroy(gameObject);
        }
    }
}
