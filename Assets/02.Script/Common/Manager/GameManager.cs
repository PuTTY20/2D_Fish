using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static UIManager UI;
    public static PoolingManager PoolManager;
    public static ObjectPooling ObjectPooling;

    void Awake()
    {
        TryGetComponent(out UI);
        TryGetComponent(out PoolManager);
        TryGetComponent(out ObjectPooling);
    }
}
