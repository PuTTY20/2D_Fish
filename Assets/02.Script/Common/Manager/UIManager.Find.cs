using UnityEngine;
using UnityEngine.UI;

public partial class UIManager : MonoBehaviour
{
    Player player;
    Transform canvas;
    Transform Life;
    Transform quest;
    Transform dieTr;
    Image[] life = new Image[3];
    Text level;
    Text content;
    Text die;

    readonly string _canvas = "Canvas";

    void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
        
        canvas = GameObject.Find(_canvas).transform;
        Life = canvas.GetChild(0).transform;

        for (int i = 0; i < 3; i++)
            life[i] = Life.GetChild(i).GetComponent<Image>();

        quest = canvas.GetChild(1).transform;
        level = quest.GetChild(0).GetChild(0).GetComponent<Text>();
        content = quest.GetChild(2).GetComponent<Text>();

        dieTr = canvas.GetChild(2).transform;
        die = dieTr.GetChild(0).GetComponent<Text>();

        GetSprite();
    }

    void Update()
        => ShowQuest();

    void GetSprite()
    {
        for (int i = 0; i < 3; i++)
            life[i].sprite = Sprites.fishImg[0];
    }
}
