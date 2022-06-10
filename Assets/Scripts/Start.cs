using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void StartLevel()
    {
        SceneManager.LoadScene("nivel 1");
    }
}
