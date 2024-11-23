using UnityEngine;
using System.Collections.Generic;

public static class Sprites
{
    public static Sprite[] fishImg;
    public static Dictionary<Player.LEVEL, Sprite> dieSprites = new Dictionary<Player.LEVEL, Sprite>();
    public static Dictionary<Player.LEVEL, Sprite> levelSprites = new Dictionary<Player.LEVEL, Sprite>();

    static Sprites()
    {
        fishImg = Resources.LoadAll<Sprite>("Sprites/fishsheet");

        int[] idx = { 0, 1, 3, 5, 7, 9, 11, 12, 13 };
        for (int i = 1; i <= 9; i++)
            levelSprites[(Player.LEVEL)i] = fishImg[idx[i - 1]];

        int[] dieIdx = { 2, 2, 4, 6, 8, 10 };
        for (int i = 1; i <= 6; i++)
            dieSprites[(Player.LEVEL)i] = fishImg[dieIdx[i - 1]];
    }
}