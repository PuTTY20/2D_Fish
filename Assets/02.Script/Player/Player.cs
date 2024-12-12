using UnityEngine;

public class Player : LevelSystem
{
    void Update()
    {
        if (dieSprite != null)
            GameManager.UI.UpdateLifeSprite(rend.sprite, dieSprite);
    }
}
