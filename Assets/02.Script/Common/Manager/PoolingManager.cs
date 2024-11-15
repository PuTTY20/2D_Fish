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
        while (true)
        {
            selectedFish = GameManager.ObjectPooling.GetFish();

            if (selectedFish != null)
                selectedFish.SetActive(true);

            yield return new WaitForSeconds(4.0f);
        }
    }
}