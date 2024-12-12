using UnityEngine;
using UnityEngine.UI;

public partial class UIManager : MonoBehaviour
{
    Transform canvas;
    Transform Life;
    Image[] life = new Image[3];
    Transform quest;
    Text level;
    Text content;

    readonly string _canvas = "Canvas";

    void Start()
    {
        canvas = GameObject.Find(_canvas).transform;
        Life = canvas.GetChild(0).transform;

        for (int i = 0; i < 3; i++)
            life[i] = Life.GetChild(i).GetComponent<Image>();

        quest = canvas.GetChild(1).transform;
        level = quest.GetChild(0).GetChild(0).GetComponent<Text>();
        content = quest.GetChild(2).GetComponent<Text>();

        GetSprite();
    }

    void Update()
        => ShowQuest();

    void GetSprite()
    {
        for (int i = 0; i < 3; i++)
            life[i].sprite = Sprites.fishImg[0];
    }

    void ShowQuest()
    {
        var currentLevel = Player.LEVEL.Level1;
        var questData = GameManager.QuestManager.GetQuestData(currentLevel);

        level.text = currentLevel.ToString();
        content.text = $"{questData.content}({questData.curCnt}/{questData.targetCnt})";
    }
}
