using UnityEngine;

public class Player : MonoBehaviour
{
    public enum LEVEL
    { Level1 = 1, Level2, Level3, Level4, Level5, Level6, Level7, level8, level9 }
    /*
    * 0: 0.7 no line purple fish
    * 1: no line purple fish.       <- player start point
    * 2: purple fish
    * 3: orange fish
    * 4: blue fish
    * 5: green fish
    * 6: red fish
    * 7: blow fish
    * 8: small eel
    * 9: eel
    */

    public LEVEL level = LEVEL.Level1;
    internal SpriteRenderer sprite;

    readonly int[] spriteIdx = { 0, 1, 3, 5, 7, 9, 11, 12, 13 };

    public void LevelSprite()
    {
        if (sprite == null)
            sprite = GetComponent<SpriteRenderer>();
        
        sprite.sprite = Sprites.fishImg[spriteIdx[(int)level - 1]];
    }
}