using UnityEngine;
using UnityEngine.UI;

public partial class UIManager : MonoBehaviour
{
    public void UpdateLife(Sprite sp, Sprite die)
    {
        if (GameManager.instance.life == 3)
        {
            for (int i = 0; i < 3; i++)
                life[i].sprite = sp;
        }

        else if (GameManager.instance.life == 2)
        {
            for (int i = 0; i < 2; i++)
                life[i].sprite = sp;

            life[2].sprite = die;
        }

        else if (GameManager.instance.life == 1)
        {
            life[0].sprite = sp;

            for (int i = 1; i < 3; i++)
                life[i].sprite = die;
        }

        else if (GameManager.instance.life == 0)
        {
            for (int i = 0; i < 3; i++)
                life[i].sprite = die;
        }
    }
}
