using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class manageGame : MonoBehaviour
{
    public GameObject completeWindow;
    public void levelComplete()
    {
        completeWindow.SetActive(true);
    }
    public void endGame()
    {
        Invoke("Restart", 1f);
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
