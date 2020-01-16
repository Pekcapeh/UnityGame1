using UnityEngine;

public class Enemy : PlayerInteracting
{
    private int _damage = 1;

    public override void PlayerOnTriggerEnter2D(Player player)
    {
        player.ApplyDamage(_damage);
    }
}
