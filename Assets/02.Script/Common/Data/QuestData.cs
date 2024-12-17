using UnityEngine;

[System.Serializable]
public class QuestData
{
    public string content;  // 퀘스트 내용
    public int targetCnt;   // 목표 수
    public int curCnt;      // 현재 진행도
    public bool isClear; // 완료 여부
}