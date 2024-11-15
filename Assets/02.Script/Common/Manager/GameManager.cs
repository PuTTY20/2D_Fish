using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static UIManager UI;
    public static PoolingManager Pool;

    void Awake()
    {
        TryGetComponent(out UI);
        TryGetComponent(out Pool);
    }
}
