using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public List<GameObject> fishList = new List<GameObject>();
    public List<GameObject> offList = new List<GameObject>();
    GameObject fishGroup;

    int size = 7;

    void Awake()
    {
        GameObject level0 = Resources.Load<GameObject>("Fish/0");
        GameObject level1 = Resources.Load<GameObject>("Fish/1");
        GameObject level2 = Resources.Load<GameObject>("Fish/2");
        GameObject level3 = Resources.Load<GameObject>("Fish/3");
        GameObject level4 = Resources.Load<GameObject>("Fish/4");
        GameObject level5 = Resources.Load<GameObject>("Fish/5");
        GameObject level6 = Resources.Load<GameObject>("Fish/6");
        GameObject level7 = Resources.Load<GameObject>("Fish/7");

        fishGroup = new GameObject("Fish Group");

        StartCoroutine(CreateFishPool(level0));
        StartCoroutine(CreateFishPool(level1));
        StartCoroutine(CreateFishPool(level2));
        StartCoroutine(CreateFishPool(level3));
        StartCoroutine(CreateFishPool(level4));
        StartCoroutine(CreateFishPool(level5));
        StartCoroutine(CreateFishPool(level6));
        StartCoroutine(CreateFishPool(level7));
    }

    IEnumerator CreateFishPool(GameObject fishLevel)
    {
        for (int i = 0; i < size; i++)
        {
            var fish = Instantiate(fishLevel, fishGroup.transform);
            fish.SetActive(false);
            fishList.Add(fish);
        }
        yield return new WaitForSeconds(0.1f);
    }

    public GameObject GetFish()
    {
        offList.Clear();

        foreach (GameObject fish in fishList)
        {
            if (!fish.activeSelf)
                offList.Add(fish);
        }

        if (offList.Count > 0)
        {
            int randomIdx = Random.Range(0, offList.Count);
            return offList[randomIdx];
        }

        return null;  // 사용 가능한 비활성화된 fish가 없으면 null 반환
    }

    public void ReturnFish(GameObject fish)
        => fish.SetActive(false);
}