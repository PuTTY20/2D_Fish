using UnityEngine;
using UnityEngine.UI;

public partial class UIManager : MonoBehaviour
{
    public void UpdateLifeSprite(Sprite sp, Sprite die)
    {
        int curLife = GameManager.instance.life;
        
        for (int i = 0; i < 3; i++)
            life[i].sprite = i < curLife ? sp : die;  // i가 curLife보다 작으면 sp, 아니면 dieSprite로 변경
    }
}
