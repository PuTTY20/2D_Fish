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

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void LevelSprite()
    {
        if (sprite == null)
            sprite = GetComponent<SpriteRenderer>();

        switch (level)
        {
            case LEVEL.Level1:
                sprite.sprite = Sprites.fishImg[0];
                break;
            case LEVEL.Level2:
                sprite.sprite = Sprites.fishImg[1];
                break;
            case LEVEL.Level3:
                sprite.sprite = Sprites.fishImg[3];
                break;
            case LEVEL.Level4:
                sprite.sprite = Sprites.fishImg[5];
                break;
            case LEVEL.Level5:
                sprite.sprite = Sprites.fishImg[7];
                break;
            case LEVEL.Level6:
                sprite.sprite = Sprites.fishImg[9];
                break;
            case LEVEL.Level7:
                sprite.sprite = Sprites.fishImg[11];
                break;
            case LEVEL.level8:
                sprite.sprite = Sprites.fishImg[12];
                break;
            case LEVEL.level9:
                sprite.sprite = Sprites.fishImg[13];
                break;
        }
    }
}