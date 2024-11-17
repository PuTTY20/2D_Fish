using UnityEngine;

public class FishMove : MonoBehaviour
{
    private float speed;
    private SpriteRenderer rend;
    private Rigidbody2D rb;

    private void Awake()
    {
        speed = Random.Range(1f, 4f);
        rend = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        rb.gravityScale = 0;
    }

    public void FishCtrl(bool rightPos)
    {
        rend.flipX = rightPos;
        
        float dir = rightPos ? -1f : 1f;
        rb.velocity = new Vector2(dir * speed, rb.velocity.y);
    }
}
