using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int score;

    public int GetScore() => score;

    public void ModifyScore(int value)
    {
        score += value;
        Mathf.Clamp(score, 0, int.MaxValue);
    }

    public void ResetScore()
    {
        score = 0;
    }
}