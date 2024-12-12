using UnityEngine;

public abstract class LevelSystem : MonoBehaviour
{
    public enum LEVEL { Level0 = 0, Level1, Level2, Level3, Level4, Level5, Level6, Level7, Level8, Level9 }
    
    public LEVEL level = LEVEL.Level1;
    public SpriteRenderer rend;

    protected virtual void Awake()
        => rend = GetComponent<SpriteRenderer>();
} 