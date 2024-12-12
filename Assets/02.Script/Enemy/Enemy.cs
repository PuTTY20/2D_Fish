using UnityEngine;

public class Enemy : LevelSystem
{
    protected override void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
    }
} 