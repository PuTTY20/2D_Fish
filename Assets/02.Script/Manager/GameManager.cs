using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static UIManager UI;

    void Awake()
    {
        TryGetComponent(out UI);
    }
}
