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
            new QuestData{ content = "물고기 5마리 잡기", targetCnt = 5, curCnt = 0 },
            new QuestData{ content = "물고기 5마리 잡기", targetCnt = 5, curCnt = 0 },
            new QuestData{ content = "물고기 10마리 잡기", targetCnt = 10, curCnt = 0 },
            new QuestData{ content = "물고기 5마리 잡기", targetCnt = 5, curCnt = 0 },
            new QuestData{ content = "물고기 10마리 잡기", targetCnt = 10, curCnt = 0 },
            new QuestData{ content = "물고기 5마리 잡기", targetCnt = 5, curCnt = 0 },
        };
    }

    void InitializeDictionary()
    {
        questDict = new Dictionary<Player.LEVEL, QuestData>();

        // Player.LEVEL enum 값을 순차적으로 할당
        for (int i = 0; i < questList.Count; i++)
        {
            Player.LEVEL level = (Player.LEVEL)i;
            questDict.Add(level, questList[i]);
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

        if (questData != null && questData.curCnt < questData.targetCnt)
            questData.curCnt += value;
    }
}
