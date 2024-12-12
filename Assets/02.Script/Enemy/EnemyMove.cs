using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Transform tr;
    private SpriteRenderer rend;
    private Rigidbody2D rb;
    private float speed;

    private void Awake()
    {
        tr = transform;
        rend = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        speed = Random.Range(1f, 4f);
        rb.gravityScale = 0;
    }

    private void Update()
        => OffFish();

    public void Move(bool rightPos)
    {
        rend.flipX = rightPos;  // 오른쪽 방향이면 왼쪽으로 뒤집음

        float dir = rightPos ? -1f : 1f;    // 오른쪽 방향이면 왼쪽으로 이동, 왼쪽 방향이면 오른쪽으로 이동
        rb.velocity = new Vector2(dir * speed, rb.velocity.y);
    }

    void OffFish()
    {
        if (transform.position.x > 10f || transform.position.x < -10f)
            GameManager.ObjectPooling.ReturnFish(gameObject);
    }
}
