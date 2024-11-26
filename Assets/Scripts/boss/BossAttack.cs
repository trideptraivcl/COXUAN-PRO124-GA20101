using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public float attackRange = 5f;
    public int damage = 10;
    public float attackCooldown = 2f;

    private float nextAttackTime = 0f;
    private Transform player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        // Kiểm tra khoảng cách đến player
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= attackRange && Time.time >= nextAttackTime)
        {
            Attack();
            nextAttackTime = Time.time + attackCooldown; // Chờ thời gian hồi
        }
    }

    void Attack()
    {
        // Thực hiện hành vi tấn công
        Debug.Log("Boss attacks the player!");

        // Gây sát thương (giả sử player có script PlayerHealth)
        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
        }

        // Gọi hoạt ảnh tấn công (nếu có Animator)
        Animator animator = GetComponent<Animator>();
        if (animator != null)
        {
            animator.SetTrigger("Attack");
        }
    }
}
