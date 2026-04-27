using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text scoreText;
    public Text highScoreText;
    public Text levelText;

    int score = 0;
    int highScore = 0;
    int level = 1;

    public float gameSpeed = 1f;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        level = PlayerPrefs.GetInt("Level", 1);

        highScoreText.text = "HighScore: " + highScore;
        levelText.text = "Nivel: " + level;
    }

    public void AddScore(int value)
    {
        score += value;

        scoreText.text = "Score: " + score;

        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }

        highScoreText.text = "HighScore: " + highScore;

        IncreaseDifficulty();
    }

    void IncreaseDifficulty()
    {
        if(score % 10 == 0)
        {
            level++;
            gameSpeed += 0.2f;

            PlayerPrefs.SetInt("Level", level);

            levelText.text = "Nivel: " + level;
        }
    }

    public void SaveGame()
    {
        PlayerPrefs.Save();
    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }
}
