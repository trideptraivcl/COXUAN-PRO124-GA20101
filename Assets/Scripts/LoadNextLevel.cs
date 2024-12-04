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
            collision.gameObject.SetActive(false); // Vô hiệu hóa đối tượng Player
            ModeSelect(); // Gọi hàm chuyển scene
        }
    }

    public void ModeSelect()
    {
        StartCoroutine(LoadAfterDelay()); // Bắt đầu coroutine
    }

    IEnumerator LoadAfterDelay()
    {
        yield return new WaitForSeconds(delaySecond); // Chờ trong khoảng thời gian chỉ định
        SceneManager.LoadScene(nameScene); // Chuyển đến scene mới
        Destroy(gameObject);

    }
}
