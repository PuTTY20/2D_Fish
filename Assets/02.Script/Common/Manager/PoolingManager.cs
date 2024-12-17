using System.Collections;
using UnityEngine;

public class PoolingManager : MonoBehaviour
{
    GameObject selectedFish = null;
    Coroutine spawnCoroutine = null;

    void Start()
        => StartCoroutine(ActivatePlatforms());

    public IEnumerator ActivatePlatforms()
    {
        while (!GameManager.instance.isGameOver)
        {
            if (selectedFish = GameManager.ObjectPooling.GetFish())
            {
                Vector2 spawnPos = GetRandomPos();
                selectedFish.transform.position = spawnPos;
                selectedFish.SetActive(true);
                selectedFish.GetComponent<EnemyMove>().Move(spawnPos.x > 0);
                yield return new WaitForSeconds(0.5f);
            }
        }
    }

    private Vector2 GetRandomPos()
    {
        float x = Random.Range(0, 2) == 0 ? -10f : 10f;
        float y = Random.Range(-4.7f, 4.7f);
        return new Vector2(x, y);
    }

    // 이전 코루틴 중지 후 새로운 코루틴 시작
    public void RestartSpawn()
    {
        if (spawnCoroutine != null)
            StopCoroutine(spawnCoroutine);
            
        spawnCoroutine = StartCoroutine(ActivatePlatforms());
    }
}