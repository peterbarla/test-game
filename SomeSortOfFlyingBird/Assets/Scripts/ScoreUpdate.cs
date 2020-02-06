using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    private Text scoreText;
    private string score;
    public float number = 0f;
    private void Awake()
    {
        scoreText = GetComponent<Text>();

        score = scoreText.text;
    }
    void Update()
    {
        scoreText.text = score + number;
    }
}
