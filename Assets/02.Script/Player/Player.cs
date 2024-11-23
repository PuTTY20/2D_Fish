using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public enum LEVEL { Level1 = 1, Level2, Level3, Level4, Level5, Level6, Level7, Level8, Level9 }
    
    public LEVEL level = LEVEL.Level1;
    internal SpriteRenderer rend;

    void Awake()
        => rend = GetComponent<SpriteRenderer>();

    void Update()
    {
        if (Sprites.dieSprites.TryGetValue(level, out Sprite dieSprite))
            GameManager.UI.UpdateLife(rend.sprite, dieSprite);
    }
    
    public void LevelSprite()
        => rend.sprite = Sprites.levelSprites[level];
}
