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
            new QuestData{ content = "물고기 10마리 잡기", targetCnt = 10, curCnt = 0 },
            new QuestData{ content = "물고기 15마리 잡기", targetCnt = 15, curCnt = 0 },
            new QuestData{ content = "물고기 20마리 잡기", targetCnt = 20, curCnt = 0 },
            new QuestData{ content = "물고기 25마리 잡기", targetCnt = 25, curCnt = 0 },
            new QuestData{ content = "물고기 30마리 잡기", targetCnt = 30, curCnt = 0 }
        };
    }

    void InitializeDictionary()
    {
        questDict = new Dictionary<Player.LEVEL, QuestData>();

        // LEVEL_1부터 LEVEL_6까지만 퀘스트 할당
        for (int i = 1; i <= 6; i++)
        {
            Player.LEVEL level = (Player.LEVEL)i;
            questDict.Add(level, questList[i-1]);  // i-1로 수정
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

        if (questData != null && !questData.isCompleted && questData.curCnt < questData.targetCnt)
        {
            questData.curCnt += value;
            
            // 퀘스트 완료 체크
            if (questData.curCnt >= questData.targetCnt)
            {
                questData.isCompleted = true;
                questData.curCnt = questData.targetCnt;  // 최대값으로 고정
                
                // 플레이어 레벨업
                if (GameManager.instance.player != null)
                    GameManager.instance.player.LevelUp();
            }
        }
    }
}
