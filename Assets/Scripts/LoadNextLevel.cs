using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadNextLevel : MonoBehaviour
{
    public float delaySecond = 4f; // Thời gian chờ trước khi chuyển scene
    public string nameScene = "map2"; // Tên scene sẽ được tải

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Player triggered the level change!");
            ModeSelect(); // Gọi hàm chuyển scene
        }
    }

    public void ModeSelect()
    {
        StartCoroutine(LoadAfterDelay()); // Bắt đầu coroutine
    }

    IEnumerator LoadAfterDelay()
    {
        Debug.Log($"Loading scene: {nameScene} after {delaySecond} seconds...");

        yield return new WaitForSeconds(delaySecond); // Chờ trong khoảng thời gian chỉ định

        // Kiểm tra nếu Camera chính có tồn tại
        if (Camera.main == null)
        {
            Debug.LogWarning("No Main Camera in the current scene! Please add a Camera to the scene.");
        }

        // Chuyển scene
        SceneManager.LoadScene(nameScene);
        Debug.Log($"Scene {nameScene} loaded successfully!");
    }
}
