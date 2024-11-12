using UnityEngine;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        GameManager.NewGame();
    }

    public void LoadMenu()
    {
        GameManager.LoadMenu();
    }
    
    public void QuitGame()
    {
        GameManager.QuitGame();
    }
}