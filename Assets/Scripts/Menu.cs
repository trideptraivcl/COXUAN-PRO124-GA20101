using UnityEngine;
using UnityEngine.SceneManagement; // Sửa lại 'SceneManagerment' thành 'SceneManagement'
using System.Collections;
using System.Collections.Generic;

public class Menu : MonoBehaviour
{
    // Phương thức PlayGame sẽ được gọi khi người chơi nhấn nút Play
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1); // Tải scene có chỉ số 1 (thường là scene thứ hai trong Build Settings)
    }
}
