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
    internal SpriteRenderer rend;

    readonly int[] spriteIdx = { 0, 1, 3, 5, 7, 9, 11, 12, 13 };

    private Sprite die12;
    private Sprite die3;
    private Sprite die4;
    private Sprite die5;
    private Sprite die6;

    void Awake()
    {
        die12 = Sprites.fishImg[2];
        die3 = Sprites.fishImg[4];
        die4 = Sprites.fishImg[6];
        die5 = Sprites.fishImg[8];
        die6 = Sprites.fishImg[10];
    }

    void Start()
        => rend = GetComponent<SpriteRenderer>();

    void Update()
    {
        if (level == LEVEL.Level1) GameManager.UI.UpdateLife(rend.sprite, die12);
        else if (level == LEVEL.Level2) GameManager.UI.UpdateLife(rend.sprite, die12);
        else if (level == LEVEL.Level3) GameManager.UI.UpdateLife(rend.sprite, die3);
        else if (level == LEVEL.Level4) GameManager.UI.UpdateLife(rend.sprite, die4);
        else if (level == LEVEL.Level5) GameManager.UI.UpdateLife(rend.sprite, die5);
        else if (level == LEVEL.Level6) GameManager.UI.UpdateLife(rend.sprite, die6);
    }
    
    public void LevelSprite()
    {
        if (rend == null)
            rend = GetComponent<SpriteRenderer>();

        rend.sprite = Sprites.fishImg[spriteIdx[(int)level - 1]];
    }
}