using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int Damage = 1;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            collision.GetComponent<Player>().ApplyDamage(Damage);
        }
    }
}
