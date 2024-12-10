using UnityEngine;

public class PhaseManager : MonoBehaviour
{
    public PhaseObjects[] phases;
    public int currentPhase = 0;

    void Start()
    {
        SwitchPhase(currentPhase, true);
    }
    
    public void NextPhase()
    {
        if (currentPhase >= phases.Length - 1) return;
        SwitchPhase(currentPhase, false);
        currentPhase++;
        SwitchPhase(currentPhase, true);
    }

    private void SwitchPhase(int phaseNumber, bool enabled)
    {
        foreach (var obj in phases[phaseNumber].objects)
        {
            obj.SetActive(enabled);
        }
    }
}

[System.Serializable]
public struct PhaseObjects
{
    public GameObject[] objects;
}
