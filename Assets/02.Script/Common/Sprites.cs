using UnityEngine;

public static class Sprites
{
    public static Sprite[] fishImg;

    static Sprites()
        => fishImg = Resources.LoadAll<Sprite>("Sprites/fishsheet");
}