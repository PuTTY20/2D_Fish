using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static UIManager UI;
    public static PoolingManager PoolManager;
    public static ObjectPooling ObjectPooling;

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

        GetComponents();
    }

    void GetComponents()
    {
        TryGetComponent(out UI);
        TryGetComponent(out PoolManager);
        TryGetComponent(out ObjectPooling);
    }
}
