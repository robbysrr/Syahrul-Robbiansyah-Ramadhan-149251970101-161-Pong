using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void OpenAuthor()
    {
        Debug.Log("Created by Syahrul Robbiansyah Ramadhan - 149251970101-161");
    }
    public void OpenCredit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void OpenMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
