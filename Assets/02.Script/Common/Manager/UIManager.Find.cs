using UnityEngine;
using UnityEngine.UI;

public partial class UIManager : MonoBehaviour
{
    Transform canvas;
    Transform Life;
    Image fish1;
    Image fish2;
    Image fish3;

    readonly string can = "Canvas";

    void Start()
    {
        canvas = GameObject.Find(can).transform;
        Life = canvas.GetChild(0).transform;
        fish1 = Life.GetChild(0).GetComponent<Image>();
        fish2 = Life.GetChild(1).GetComponent<Image>();
        fish3 = Life.GetChild(2).GetComponent<Image>();
    }
}
