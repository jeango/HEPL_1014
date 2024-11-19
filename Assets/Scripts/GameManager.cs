using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    private static string gameSceneName = "Game";
    private static string menuSceneName = "MainMenu";
    private static string gameOverSceneName = "GameOver";
    
    public static int score = 0;
    public static int highScore = 0;
    
    public static void SaveHighScore()
    {
        highScore = score;
        PlayerPrefs.SetInt("HighScore", highScore);
    }

    public static void LoadHighScore()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }
    
    public static void NewGame()
    {
        score = 0;
        LoadHighScore();
        SceneManager.LoadScene(gameSceneName);
    }

    public static void GameOver()
    {
        if (highScore < score)
        {
            SaveHighScore();
        }
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
