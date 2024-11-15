using System.Collections;
using System.Collections.Generic;
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
            selectedFish = GameManager.ObjectPooling.GetFish();

            if (selectedFish != null)
            {
                selectedFish.SetActive(true);

                float x = Random.Range(0, 2) == 0 ? -10f : 10f;
                float y = Random.Range(-4.7f, 4.7f);

                selectedFish.transform.position = new Vector2(x, y);

                yield return new WaitForSeconds(2.0f);
            }
        }
    }
}