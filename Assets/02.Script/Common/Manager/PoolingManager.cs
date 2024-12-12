using System.Collections;
using UnityEngine;

public class PoolingManager : MonoBehaviour
{
    GameObject selectedFish = null;

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
                yield return new WaitForSeconds(2.0f);
            }
        }
    }

    private Vector2 GetRandomPos()
    {
        float x = Random.Range(0, 2) == 0 ? -10f : 10f;
        float y = Random.Range(-4.7f, 4.7f);
        return new Vector2(x, y);
    }
}