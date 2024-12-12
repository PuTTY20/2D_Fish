using UnityEngine;

public class Damage : MonoBehaviour
{
    Player player;

    int life = 0;
    int initLife = 3;

    void Start()
    {
        life = initLife;
        player = GetComponent<Player>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.TryGetComponent(out Enemy _enemy) && life > 0)
        {
            if (_enemy.level > player.level)
            {
                life--;
                GameManager.instance.life = life;

                if (life == 0)
                    GameManager.instance.isGameOver = true;
            }

            else if (_enemy.level <= player.level)
                GameManager.QuestManager.QuestProgress(player.level, 1);
        }
    }
}
