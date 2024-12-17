using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player { get; private set; }

    public static UIManager UI;
    public static PoolingManager PoolManager;
    public static ObjectPooling ObjectPooling;
    public static QuestManager QuestManager;
    public static SceneLoader Scene;

    public int life = 3;
    public bool isGameOver = false;

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
}
