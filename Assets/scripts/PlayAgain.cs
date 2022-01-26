using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayAgain : MonoBehaviour
{
    public void click()
    {
        SceneManager.LoadScene("Game");
    }
}
