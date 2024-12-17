using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    Canvas canvas;
    Text levelUp;

    void Start()
    {
        canvas = transform.GetChild(0).GetComponent<Canvas>();
        levelUp = canvas.transform.GetChild(0).GetComponent<Text>();
        
        levelUp.gameObject.SetActive(false);
    }

    public void ShowLevelUpText()
    {
        levelUp.gameObject.SetActive(true);
        Invoke("HideLevelUpText", 1f);
    }

    void HideLevelUpText()
        => levelUp.gameObject.SetActive(false);
}
