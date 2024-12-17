using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player { get; private set; }

    public static UIManager UI;
    public static PoolingManager PoolManager;
    public static ObjectPooling ObjectPooling;
    public static QuestManager QuestManager;
    public static SceneLoader Scene;

    public bool isGameOver = false;

    private int _life = 3;
    public int Life
    {
        get => _life;
        set
        {
            _life = value;
            OnLifeUpdate?.Invoke(_life);
        }
    }
    public Action<int> OnLifeUpdate;
    
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        player = FindObjectOfType<Player>();

        GetComponents();
    }

    void GetComponents()
    {
        TryGetComponent(out UI);
        TryGetComponent(out PoolManager);
        TryGetComponent(out ObjectPooling);
        TryGetComponent(out QuestManager);
        TryGetComponent(out Scene);
    }

    public void Reset()
    {
        isGameOver = false;
        Life = 3;

        player.ResetPlayer();
        QuestManager.QuestReset();
        ObjectPooling.PoolReset();
        PoolManager.RestartSpawn();
    }
}
