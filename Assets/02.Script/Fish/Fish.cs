using UnityEngine;

public class Fish : MonoBehaviour
{
    public Player.LEVEL level { get; private set; }
    private FishMove movement;

    private void Awake() => movement = GetComponent<FishMove>();

    public void Initialize(Player.LEVEL fishLevel) => level = fishLevel;
} 