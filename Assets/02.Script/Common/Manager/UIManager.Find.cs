using UnityEngine;
using UnityEngine.UI;

public partial class UIManager : MonoBehaviour
{
    Player player;

    Transform canvas;
    Transform lifeTr;
    Transform questTr;
    Transform dieTr;
    Image[] life = new Image[3];
    Button backBtn;
    Button replayBtn;
    Text level;
    Text content;

    readonly string _canvas = "UI";

    void Start()
    {
        player = GameObject.FindObjectOfType<Player>();

        canvas = GameObject.Find(_canvas).transform;
        lifeTr = canvas.GetChild(0).transform;

        for (int i = 0; i < 3; i++)
            life[i] = lifeTr.GetChild(i).GetComponent<Image>();

        questTr = canvas.GetChild(1).transform;
        level = questTr.GetChild(0).GetChild(0).GetComponent<Text>();
        content = questTr.GetChild(2).GetComponent<Text>();

        dieTr = canvas.GetChild(2).transform;
        dieTr.gameObject.SetActive(false);
        backBtn = dieTr.GetChild(1).GetComponent<Button>();
        replayBtn = dieTr.GetChild(2).GetComponent<Button>();
        backBtn.onClick.AddListener(GameManager.Scene.LoadStartScene);
        replayBtn.onClick.AddListener(() =>
        {
            dieTr.gameObject.SetActive(false);
            GameManager.instance.Reset();
        });

        GetSprite();
    }

    void Update()
        => ShowQuest();

    void GetSprite()
    {
        for (int i = 0; i < 3; i++)
            life[i].sprite = Sprites.fishImg[0];
    }
}
