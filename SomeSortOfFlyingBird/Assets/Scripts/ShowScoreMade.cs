using UnityEngine;
using UnityEngine.UI;

public class ShowScoreMade : MonoBehaviour
{
    private Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = "YOU DIED...\nYOUR SCORE: " + PlayerPrefs.GetFloat("Score");
    }
}
