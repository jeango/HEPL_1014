using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    private static string gameSceneName = "Game";
    private static string menuSceneName = "MainMenu";
    private static string gameOverSceneName = "GameOver";
    
    public static void NewGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public static void GameOver()
    {
        SceneManager.LoadScene(gameOverSceneName, LoadSceneMode.Additive);
    }
    
    public static void LoadMenu()
    {
        SceneManager.LoadScene(menuSceneName);
    }
    
    public static void QuitGame()
    {
        Application.Quit();
    }    
}
