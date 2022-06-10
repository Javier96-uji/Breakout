using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public float moveSpeed = 25f;
    private float inputValue;
    private Vector2 direction;

    Vector2 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        inputValue = Input.GetAxisRaw("Horizontal");

        Debug.Log(inputValue);
        Vector2 position = transform.position;
        position.x = position.x + 0.1f * inputValue;
        transform.position = position;

        rigidBody2D.AddForce(direction * moveSpeed * Time.deltaTime * 100);
    }

    public void ResetPlayer()
    {
        transform.position = startPosition;
        rigidBody2D.velocity = Vector2.zero;
    }
}
