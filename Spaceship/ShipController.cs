using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public GameManager _gameManager;
    public GameObject _bulletPrefab;
    public float _speed = 10f;
    public float _xLimit = 7f;
    public float _reloadTime = 0.5f;

    float _elapsedTime = 0f;

    private void Update()
    {
        if (transform.position.x <-_xLimit)
        {
            transform.position = new Vector3(-_xLimit, transform.position.y, transform.position.z);
        }

        if (transform.position.x > _xLimit)
        {
            transform.position = new Vector3(_xLimit, transform.position.y, transform.position.z);
        }

        // ������ ������� ����� ��������
        _elapsedTime += Time.deltaTime;

        // ����������� ������ ����� � ������
        float xInput = Input.GetAxis("Horizontal");
        transform.Translate(xInput * _speed * Time.deltaTime, 0f, 0f);

        // ��������� ��������� ������� �� ��� x
        Vector3 _position = transform.position;
        _position.x = Mathf.Clamp(_position.x, -_xLimit, _xLimit);
        transform.position = _position;

        // ����� �������� "������". ���� �� ��������� � InputManager
        // ���������� "Jump"
        // ����������� ������ � ��� ������, ���� ����� �����������
        // ��� ������

        if (Input.GetButtonDown("Jump") && _elapsedTime > _reloadTime)
        {
            // �������� ���������� ������� �� ���������� 1, 2 �������
            // ����� �������
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(0, 1.2f, 0);
            Instantiate(_bulletPrefab, spawnPos, Quaternion.identity);

            _elapsedTime = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _gameManager.PlayerDied();
    }
}
