using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerInteracting : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            PlayerOnTriggerEnter2D(player);
            Destroy(gameObject);
        }
    }

    public abstract void PlayerOnTriggerEnter2D(Player player);
}
