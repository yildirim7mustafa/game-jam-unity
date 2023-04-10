using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void QuitGame()
    {
        Debug.Log("Quiting...");
        Application.Quit();
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("BASLANGIC_SAYFASI");
        Key.Count = 0;
    }

    public void Dead()
    {
        SceneManager.LoadScene("map");
        Key.Count = 0;
    }

    public void Win()
    {
        SceneManager.LoadScene("basardin");
        Key.Count = 0;
    }

    public void Credit()
    {
        SceneManager.LoadScene("emegi_gecenler");
        Key.Count = 0;
    }


}
