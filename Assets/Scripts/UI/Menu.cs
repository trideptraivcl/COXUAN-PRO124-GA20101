using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
  public void PlayGame()
    {
        SceneManager.LoadScene("map1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
