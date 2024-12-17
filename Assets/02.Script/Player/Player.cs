using UnityEngine;

public class Player : LevelSystem
{
    Transform tr;
    protected Sprite dieSprite;

    protected override void Awake()
    {
        base.Awake();
        UpdateDieSprite();
    }

    void Start() => tr = transform;

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
        GameManager.instance.Life = 3;
        LevelSprite();
        SendMessage("ShowLevelUpText");
    }


    public virtual void LevelSprite()
    {
        if (rend == null)
            rend = GetComponent<SpriteRenderer>();

        rend.sprite = Sprites.levelSprites[level];
        UpdateDieSprite();
    }

    public void ResetPlayer()
    {
        tr.position = Vector2.zero;
        level = LEVEL.Level1;
        LevelSprite();
    }
}
