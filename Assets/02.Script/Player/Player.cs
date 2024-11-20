using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public enum LEVEL { Level1 = 1, Level2, Level3, Level4, Level5, Level6, Level7, level8, level9 }

    private Dictionary<LEVEL, Sprite> dieSprites = new Dictionary<LEVEL, Sprite>();
    
    public LEVEL level = LEVEL.Level1;
    internal SpriteRenderer rend;

    private readonly int[] spriteIdx = { 0, 1, 3, 5, 7, 9, 11, 12, 13 };

    void Awake()
    {
        dieSprites[LEVEL.Level1] = Sprites.fishImg[2];
        dieSprites[LEVEL.Level2] = Sprites.fishImg[2];
        dieSprites[LEVEL.Level3] = Sprites.fishImg[4];
        dieSprites[LEVEL.Level4] = Sprites.fishImg[6];
        dieSprites[LEVEL.Level5] = Sprites.fishImg[8];
        dieSprites[LEVEL.Level6] = Sprites.fishImg[10];
        
        rend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (dieSprites.TryGetValue(level, out Sprite dieSprite))
            GameManager.UI.UpdateLife(rend.sprite, dieSprite);
    }
    
    public void LevelSprite()
        => rend.sprite = Sprites.fishImg[spriteIdx[(int)level - 1]];
}