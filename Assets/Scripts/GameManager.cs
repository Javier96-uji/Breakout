using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int vidas = 3;

    public void LoseHealth()
    {
        vidas --;

        if (vidas <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        else
        {
            ResetLevel();
        }
    }

    public void ResetLevel()
    {
        FindObjectOfType<Ball>().ResetBall();
        FindObjectOfType<Player>().ResetPlayer();
    }

    public void NivelCompletado()
    {
        if (transform.childCount <= 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
