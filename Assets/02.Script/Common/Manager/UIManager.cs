using UnityEngine;
using UnityEngine.UI;

public partial class UIManager : MonoBehaviour
{
    public void UpdateLife(Sprite sp)
    {
        if (GameManager.instance.life == 3)
        {
            fish1.sprite = sp;
            fish2.sprite = sp;
            fish3.sprite = sp;
        }

        else if (GameManager.instance.life == 2)
        {
            fish1.sprite = sp;
            fish2.sprite = sp;
            fish3.sprite = null;
        }

        else if (GameManager.instance.life == 1)
        {
            fish1.sprite = sp;
            fish2.sprite = null;
            fish3.sprite = null;
        }

        else if (GameManager.instance.life == 0)
        {
            fish1.sprite = null;
            fish2.sprite = null;
            fish3.sprite = null;
        }
    }
}
