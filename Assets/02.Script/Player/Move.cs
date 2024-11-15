using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movement;   // Stores the movement input as a 2D vector

    [SerializeField] float moveSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }
}