using UnityEngine;

public class Coin : PlayerInteracting
{
    private int _money = 1;

    public override void PlayerOnTriggerEnter2D(Player player)
    {
        player.AddMoney(_money);
    }    
}
