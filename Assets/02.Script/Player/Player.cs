using UnityEngine;

public class Player : MonoBehaviour
{
    public enum LEVEL { Level0 = 0, Level1, Level2, Level3, Level4, Level5, Level6, Level7, Level8, Level9 }
    
    public LEVEL level = LEVEL.Level1;
    internal SpriteRenderer rend;
    private Sprite dieSprite;

    void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
        Sprites.dieSprites.TryGetValue(level, out dieSprite);   // 현재 레벨에 해당하는 dieSprite 미리 저장
    }

    void Update()
    {
        if (dieSprite != null)
            GameManager.UI.UpdateLifeSprite(rend.sprite, dieSprite);
    }
    
    // 레벨에 따른 스프라이트 변경
    public void LevelSprite()
    {
        if (rend == null)
            rend = GetComponent<SpriteRenderer>();  // rend가 없으면 초기화
            
        rend.sprite = Sprites.levelSprites[level];  // 현재 레벨에 맞는 스프라이트로 변경
        Sprites.dieSprites.TryGetValue(level, out dieSprite);  // dieSprite 업데이트
    }
}
