using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player; // Gắn player vào đây
    public float speed = 3f; // Tốc độ di chuyển
    public float stopDistance = 1.5f; // Khoảng cách dừng

    void Update()
    {
        if (player != null)
        {
            float distance = Vector3.Distance(transform.position, player.position);

            // Kiểm tra nếu chưa đến khoảng cách dừng
            if (distance > stopDistance)
            {
                // Tính hướng di chuyển
                Vector3 direction = (player.position - transform.position).normalized;
                transform.position += direction * speed * Time.deltaTime;

                // Quay mặt về hướng player
                transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));
            }
        }
    }
}
