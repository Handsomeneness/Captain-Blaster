using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float _speed = 10f;

    GameManager _gameManager;

    void Start()
    {
        _gameManager = GameObject.FindObjectOfType<GameManager>();
        Rigidbody2D _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.velocity = new Vector2(0f, _speed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
        _gameManager.AddScore();
        Destroy(gameObject);
    }

}
