using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Exitgame()
    {
        Debug.Log("Exit!");
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
