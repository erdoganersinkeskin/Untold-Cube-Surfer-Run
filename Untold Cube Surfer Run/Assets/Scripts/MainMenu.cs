using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        Debug.Log("Play Game");
        //SceneManager.LoadScene("GameScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Main_Menu()
    {
        Debug.Log("Main Menu");
        SceneManager.LoadScene("Main Menu");
    }

    public void OptionsMenu()
    {
        Debug.Log("Options");
        SceneManager.LoadScene("Options Menu");
    }

    public void ScoreMenu()
    {
        Debug.Log("Score");
        SceneManager.LoadScene("Score Menu");
    }

    public void HelpMenu()
    {
        Debug.Log("Help");
        SceneManager.LoadScene("Help Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
