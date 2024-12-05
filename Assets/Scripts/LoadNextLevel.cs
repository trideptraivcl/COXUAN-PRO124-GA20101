using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.Video;

public class LoadNextLevel : MonoBehaviour
{
    public float delaySecond = 2f; // Thời gian chờ trước khi bắt đầu loading
    public string nextScene; // Tên scene tiếp theo
    public GameObject loadingScreen; // Tham chiếu đến giao diện loading (UI Canvas)
    public VideoPlayer videoPlayer; // Tham chiếu đến Video Player

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log($"Player triggered the level change to {nextScene}!");
            ModeSelect(); // Gọi hàm chuyển scene
        }
    }

    public void ModeSelect()
    {
        StartCoroutine(LoadSceneWithVideo()); // Bắt đầu coroutine với video loading
    }

    IEnumerator LoadSceneWithVideo()
    {
        // Hiển thị màn hình loading
        if (loadingScreen != null)
        {
            loadingScreen.SetActive(true); // Bật giao diện loading
        }

        // Phát video loading nếu có
        if (videoPlayer != null)
        {
            videoPlayer.gameObject.SetActive(true); // Bật Video Player
            videoPlayer.Play();
            Debug.Log("Playing loading video...");
        }

        // Chờ thời gian delay trước khi tải scene
        yield return new WaitForSeconds(delaySecond);

        // Nếu muốn đợi video chạy xong trước khi chuyển scene
        if (videoPlayer != null)
        {
            while (videoPlayer.isPlaying)
            {
                yield return null; // Chờ đến khi video kết thúc
            }
            Debug.Log("Video finished, loading the next scene...");
        }

        // Tải scene tiếp theo
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nextScene);
        while (!asyncLoad.isDone)
        {
            Debug.Log($"Loading progress: {asyncLoad.progress * 100}%");
            yield return null;
        }

        // Tắt video loading sau khi tải scene xong
        if (videoPlayer != null)
        {
            videoPlayer.Stop();
            videoPlayer.gameObject.SetActive(false);
        }

        // Tắt màn hình loading
        if (loadingScreen != null)
        {
            loadingScreen.SetActive(false);
        }

        Debug.Log($"Scene {nextScene} loaded successfully!");
    }
}
