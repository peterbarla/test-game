using UnityEngine;
using UnityEngine.SceneManagement;

public class CollidingWithWall : MonoBehaviour
{
    private ScoreUpdate scoreUpdate;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject objectText = GameObject.Find("Text");
        scoreUpdate = objectText.GetComponent<ScoreUpdate>();
        if (collision.tag == "Wall")
        {
            PlayerPrefs.SetFloat("Score", scoreUpdate.number);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   
        }else if(collision.tag == "Score")
        {
            Destroy(collision);
            scoreUpdate.number++;
            PlayerPrefs.SetFloat("Score", scoreUpdate.number);
            if (scoreUpdate.number > PlayerPrefs.GetFloat("Highscore", 0))
            {
                PlayerPrefs.SetFloat("Highscore", scoreUpdate.number);
            }
        }
    }
}
