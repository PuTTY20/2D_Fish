using UnityEngine;

public class Move : MonoBehaviour
{
    Player _fish;
    
    Rigidbody2D rb;
    Vector2 movement;

    float moveSpeed = 5f;
    float damping = 3f; // 서서히 멈추게 할 감속 비율, 숫자 커질수록 빨리 멈춰버림

    void Start()
    {
        _fish = GetComponent<Player>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x != 0)
            _fish.sprite.flipX = movement.x < 0;
            // Debug.Log("rb.velocity" + rb.velocity); 바로 moveSpeed값인 5 나옴
    }

    void FixedUpdate()
    {
        Vector2 moveVel = movement.normalized * moveSpeed;
        rb.velocity = Vector2.Lerp(rb.velocity, moveVel, damping * Time.fixedDeltaTime);
        // Debug.Log(rb.velocity); // Lerp로 인해 moveVel값으로 서서히 올라감
    }
}