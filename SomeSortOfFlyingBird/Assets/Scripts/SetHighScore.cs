using UnityEngine;
using UnityEngine.UI;
public class SetHighScore : MonoBehaviour
{
    private Text highscoreText;
    void Start()
    {
        highscoreText = GetComponent<Text>();
        highscoreText.text = "HIGHSCORE: " + PlayerPrefs.GetFloat("Highscore");
    }


}
