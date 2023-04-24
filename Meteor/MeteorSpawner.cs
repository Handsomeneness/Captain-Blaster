using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject _meteorPrefab;
    public float _minSpawnDelay = 1f;
    public float _maxSpawnDelay = 3f;
    public float _spawnXLimit = 6f;

    private void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        float random = Random.Range(-_spawnXLimit, _spawnXLimit);
        Vector3 spawnPos = transform.position + new Vector3(random, 0f, 0f);
        Instantiate(_meteorPrefab, spawnPos, Quaternion.identity);

        Invoke("Spawn", Random.Range(_minSpawnDelay, _maxSpawnDelay));
    }
}
