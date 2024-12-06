using UnityEngine;
using UnityEngine.SceneManagement; // Để sử dụng SceneManager

public class BossController : MonoBehaviour
{
    [SerializeField] private int bossHealth = 10; // Máu của Boss
    [SerializeField] private string winSceneName = "ChienThang"; // Tên Scene chiến thắng

    // Hàm nhận sát thương
    public void TakeDamage(int damage)
    {
        bossHealth -= damage; // Giảm máu
        Debug.Log("Boss nhận sát thương. Máu còn lại: " + bossHealth);

        if (bossHealth <= 0) // Khi máu <= 0, Boss chết
        {
            Die();
        }
    }

    // Hàm xử lý khi Boss chết
    private void Die()
    {
        Debug.Log("Boss đã bị tiêu diệt!");

        // Chuyển sang Scene chiến thắng
        SceneManager.LoadScene(winSceneName);

        // Hủy đối tượng Boss (nếu cần)
        Destroy(gameObject);
    }
}
