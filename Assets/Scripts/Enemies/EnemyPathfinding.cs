using UnityEngine;

public class EnemyPathfinding : MonoBehaviour
{
    [SerializeReference] private float moveSpeed = 2f;

    private Rigidbody2D rb;
    private Vector2 moveDir;
    private KnockBack knockBack;
    private SpriteRenderer spriteRenderer;


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        knockBack = GetComponent<KnockBack>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (knockBack.GettingKnockedBack) { return; }


        rb.MovePosition(rb.position + moveDir * (moveSpeed * Time.fixedDeltaTime));

        if (moveDir.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    public void MoveTo(Vector2 targetPosition)
    {
        moveDir = targetPosition;
    }

    public void StopMoving()
    {
        moveDir = Vector3.zero;
    }
}
