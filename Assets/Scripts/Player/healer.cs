using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public GameObject gameOverUI; // Kéo UI "Game Over" vào đây trong Inspector

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Player takes damage! Current health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player died!");
        GameOver(); // Gọi hàm hiển thị UI "Game Over"
    }

    void GameOver()
    {
        // Kích hoạt UI "Game Over"
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
        }

        // Dừng thời gian trong game
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        // Reset lại thời gian
        Time.timeScale = 1f;

        // Load lại scene hiện tại
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
