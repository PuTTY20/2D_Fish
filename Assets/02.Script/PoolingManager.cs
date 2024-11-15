using System.Collections.Generic;
using UnityEngine;

public class PoolingManager : MonoBehaviour
{
    public List<GameObject> Level0List = new List<GameObject>();
    public List<GameObject> Level1List = new List<GameObject>();
    public List<GameObject> Level2List = new List<GameObject>();
    public List<GameObject> Level3List = new List<GameObject>();
    public List<GameObject> Level4List = new List<GameObject>();
    public List<GameObject> Level5List = new List<GameObject>();
    public List<GameObject> Level6List = new List<GameObject>();
    public List<GameObject> Level7List = new List<GameObject>();

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
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
