using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingManager : MonoBehaviour
{
    Vector2 yPos = new Vector2(-4.7f, 4.7f);

    float spawnInterval = 2.0f;
    float xPos = 10f;
    
    GameObject selectedFish;
    
    void Start() => StartCoroutine(SpawnFishRoutine());
    
    IEnumerator SpawnFishRoutine()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnInterval); // 캐싱하여 가비지 생성 방지
        
        while (!GameManager.instance.isGameOver)
        {
            if (TrySpawnFish())
                yield return wait;
        }
    }
    
    private bool TrySpawnFish()
    {
        selectedFish = GameManager.ObjectPooling.GetFish();

        if (selectedFish == null) return false;
        
        SetFishPosition();
        selectedFish.SetActive(true);
        return true;
    }
    
    private void SetFishPosition()
    {
        float x = Random.Range(0, 2) == 0 ? -xPos : xPos;
        float y = Random.Range(yPos.x, yPos.y);
        selectedFish.transform.position = new Vector2(x, y);
    }
}