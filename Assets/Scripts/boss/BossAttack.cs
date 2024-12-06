using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public float attackRange = 5f;       // Phạm vi tấn công của Boss
    public int damage = 10;             // Sát thương Boss gây ra
    public float attackCooldown = 2f;   // Thời gian hồi mỗi đòn tấn công

    private float nextAttackTime = 0f;
    private Transform player;

    void Start()
    {
        // Tìm kiếm Player qua Tag
        GameObject playerObject = GameObject.FindWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.transform;
        }
        else
        {
            Debug.LogWarning("Player not found in the scene. Please ensure the Player has the tag 'Player'.");
        }
    }

    void Update()
    {
        if (player == null) return; // Kiểm tra Player có tồn tại

        // Kiểm tra khoảng cách đến Player
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= attackRange && Time.time >= nextAttackTime)
        {
            Attack();
            nextAttackTime = Time.time + attackCooldown; // Thời gian hồi sau khi tấn công
        }
    }

    void Attack()
    {
        // Thực hiện hành vi tấn công
        Debug.Log("Boss attacks the player!");

        // Gây sát thương cho Player
        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage, transform);
        }

        // Kích hoạt hoạt ảnh tấn công (nếu có Animator)
        Animator animator = GetComponent<Animator>();
        if (animator != null)
        {
            animator.SetTrigger("Attack");
        }
    }
}
