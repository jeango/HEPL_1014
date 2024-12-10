using UnityEngine;

public class ScoreBasedPhaseSwitcher : MonoBehaviour
{

    public int[] scoreThresholds;
    public PhaseManager phaseManager;
    private int currentThreshold;
    
    // Update is called once per frame
    void Update()
    {
        if (currentThreshold > scoreThresholds.Length - 1) return;
        if (GameManager.score > scoreThresholds[currentThreshold])
        {
            currentThreshold++;
            phaseManager.NextPhase();
        }
    }
}
