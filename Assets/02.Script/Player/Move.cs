using UnityEngine;

public class Move : MonoBehaviour
{
    Player player;

    Rigidbody2D rb;
    Vector2 movement;

    float moveSpeed = 5f;
    float damping = 3f; // 서서히 멈추게 할 감속 비율, 숫자 커질수록 빨리 멈춰버림

    void Start()
    {
        player = GetComponent<Player>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movement();
        SpriteFlip();
    }

    void Movement()
    {
        movement = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        ).normalized;
    }

    void SpriteFlip()
    {
        if (movement.x != 0)
            player.sprite.flipX = movement.x < 0;
        // Debug.Log("rb.velocity" + rb.velocity); 바로 moveSpeed값인 5 나옴
    }

    void FixedUpdate()
        => rb.velocity = Vector2.Lerp(rb.velocity, movement * moveSpeed, damping * Time.fixedDeltaTime);
}