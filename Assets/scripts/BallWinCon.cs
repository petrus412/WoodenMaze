using UnityEngine.SceneManagement;
using UnityEngine;

public class BallWinCon : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Lose")
        {
            gameObject.transform.position = new Vector3(0, -3, 0);
        }
        else if (collision.gameObject.tag == "Win") 
        {
            SceneManager.LoadScene("Win");
        }
    }
}
