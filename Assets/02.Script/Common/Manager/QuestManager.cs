using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    List<QuestData> questList = new List<QuestData>();
    Dictionary<Player.LEVEL, QuestData> questDict;

    void Awake()
    {
        QuestContents();
        InitializeDictionary();
    }

    void QuestContents()
    {
        questList = new List<QuestData>()
        {
            new QuestData{ content = "물고기 5마리 잡기", targetCnt = 5, curCnt = 0 },       // 1 to 2
            new QuestData{ content = "물고기 10마리 잡기", targetCnt = 10, curCnt = 0 },     // 2 to 3
            new QuestData{ content = "물고기 15마리 잡기", targetCnt = 15, curCnt = 0 },     // 3 to 4
            new QuestData{ content = "물고기 20마리 잡기", targetCnt = 20, curCnt = 0 },     // 4 to 5
            new QuestData{ content = "물고기 25마리 잡기", targetCnt = 25, curCnt = 0 },     // 5 to 6
            new QuestData{ content = "물고기 30마리 잡기", targetCnt = 30, curCnt = 0 },     // 6 to 7

            new QuestData{ content = "작은 장어 물리치기", targetCnt = 1, curCnt = 0 },
            new QuestData{ content = "장어 물리치기", targetCnt = 1, curCnt = 0 }

            // 만렙 도달
        };
    }

    void InitializeDictionary()
    {
        questDict = new Dictionary<Player.LEVEL, QuestData>();

        for (int i = 1; i <= 8; i++)
        {
            Player.LEVEL level = (Player.LEVEL)i;
            questDict.Add(level, questList[i-1]);
        }
    }

    public QuestData GetQuestData(int level)
    {
        Player.LEVEL playerLevel = (Player.LEVEL)level;

        // Dictionary에 해당 레벨이 없으면 null 반환
        if (!questDict.ContainsKey(playerLevel))
            return null;

        return questDict[playerLevel];
    }

    public void QuestProgress(int level, int value)
    {
        var questData = GetQuestData(level);

        if (questData != null && !questData.isClear && questData.curCnt < questData.targetCnt)
        {
            questData.curCnt += value;
            
            // 퀘스트 완료 체크
            if (questData.curCnt >= questData.targetCnt)
            {
                questData.isClear = true;
                questData.curCnt = questData.targetCnt;  // 최대값으로 고정
                
                // 플레이어 레벨업
                if (GameManager.instance.player != null)
                    GameManager.instance.player.LevelUp();
            }
        }
    }

    public void QuestReset()
    {
        foreach (var quest in questList)
        {
            quest.curCnt = 0;
            quest.isClear = false;
        }
    }
}
