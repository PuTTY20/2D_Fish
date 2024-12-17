using UnityEngine;

public class Player : LevelSystem
{
    protected Sprite dieSprite;

    protected override void Awake()
    {
        base.Awake();
        UpdateDieSprite();
    }

    protected void UpdateDieSprite()
    {
        Sprites.dieSprites.TryGetValue(level, out dieSprite);
    }

    void Update()
    {
        if (dieSprite != null)
            GameManager.UI.UpdateLifeSprite(rend.sprite, dieSprite);
    }

    public void LevelUp()
    {
        level++;
        GameManager.instance.life = 3;
        LevelSprite();
    }


    public virtual void LevelSprite()
    {
        if (rend == null)
            rend = GetComponent<SpriteRenderer>();

        rend.sprite = Sprites.levelSprites[level];
        UpdateDieSprite();
    }
}
