using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int score;

    private static ScoreKeeper instance;

    public int GetScore() => score;

    private void Awake() => ManageSingleton();

    private void ManageSingleton()
    {
        if (instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ModifyScore(int value)
    {
        score += value;
        Mathf.Clamp(score, 0, int.MaxValue);
    }

    public void ResetScore() => score = 0;
}