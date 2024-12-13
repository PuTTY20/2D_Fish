using UnityEngine;

public partial class UIManager : MonoBehaviour
{
    public void UpdateLifeSprite(Sprite sp, Sprite die)
    {
        int curLife = GameManager.instance.life;

        for (int i = 0; i < 3; i++)
            life[i].sprite = i < curLife ? sp : die;  // i가 curLife보다 작으면 sp, 아니면 dieSprite로 변경
    }

    void ShowQuest()
    {
        if (GameManager.QuestManager == null) return;
        
        var currentLevel = (int)player.level;
        var questData = GameManager.QuestManager.GetQuestData(currentLevel);

        level.text = "Level " + currentLevel.ToString();
        content.text = $"{questData.content}({questData.curCnt}/{questData.targetCnt})";
    }
}
