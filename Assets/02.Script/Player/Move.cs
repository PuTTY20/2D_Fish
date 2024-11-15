using UnityEngine;

public class Move : MonoBehaviour
{
    Fish _fish;
    
    Rigidbody2D rb;
    Vector2 movement;

    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float drag = 3f; // 서서히 멈추게 할 감속 비율, 숫자 커질수록 빨리 멈춰버림

    void Start()
    {
        _fish = GetComponent<Fish>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x != 0)
            _fish.sprite.flipX = movement.x < 0;
    }

    void FixedUpdate()
    {
        // 목표 속도를 moveSpeed와 movement로 계산
        Vector2 velocity = movement.normalized * moveSpeed;

        // 현재 속도와 목표 속도 사이에서 서서히 감속
        rb.velocity = Vector2.Lerp(rb.velocity, velocity, drag * Time.fixedDeltaTime);
    }
}
