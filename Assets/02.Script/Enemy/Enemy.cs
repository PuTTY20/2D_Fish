using UnityEngine;

public class Enemy : LevelSystem
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.TryGetComponent(out Player player))
        {
            if (player.level >= level)
                GameManager.ObjectPooling.ReturnFish(this.gameObject);
        }
    }
}