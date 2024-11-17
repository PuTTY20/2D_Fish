using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static UIManager UI;
    public static PoolingManager PoolManager;
    public static ObjectPooling ObjectPooling;

    public bool isGameOver = false;

    void Awake()
    {
        if (instance != null && instance != this)   // 이미 인스턴스가 존재하고 현재 인스턴스가 아니면
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        
        GetComponents();
    }
    
    void GetComponents()
    {
        TryGetComponent(out UI);
        TryGetComponent(out PoolManager);
        TryGetComponent(out ObjectPooling);
    }
}
