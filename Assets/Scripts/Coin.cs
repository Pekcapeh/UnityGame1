using UnityEngine;

public class Coin : MonoBehaviour
{
    private int Money = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            collision.GetComponent<Player>().AddMoney(Money);
            Destroy(gameObject);
        }
    }
}
