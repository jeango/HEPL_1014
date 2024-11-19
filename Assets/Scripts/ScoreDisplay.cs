using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public ScoreType type;
    public TMP_Text displayText;

    // Update is called once per frame
    void Update()
    {
        switch (type)
        {
            case ScoreType.Score:
                displayText.text = GameManager.score.ToString();
                break;
            case ScoreType.HighScore:
                displayText.text = GameManager.highScore.ToString();
                break;
        }
    }
    
    public enum ScoreType
    {
        Score,
        HighScore,
    }
}
