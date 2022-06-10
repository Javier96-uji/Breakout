using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladrillos : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            FindObjectOfType<GameManager>().NivelCompletado();

            Destroy(gameObject);
        }
    }
}
