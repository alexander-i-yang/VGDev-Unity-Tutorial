using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;

    public float MinDist = 5f;
    public float MaxDist = 10f;

    public float EnemySpawnRate = 1f;
    private float _nextActionTime;
    
    // Start is called before the first frame update
    void Start() {
        _nextActionTime = Time.time;
    }

    // Update is called once per frame
    void Update() {
        if (Time.time > _nextActionTime ) {
            _nextActionTime += EnemySpawnRate;
            Instantiate(EnemyPrefab, RandomPos(), Quaternion.identity);
        }

    }

    Vector3 RandomPos() {
        double a = Random.Range(0, 120f);
        double angle = a/180*Math.PI;
        double distance = Random.Range(MinDist, MaxDist);
        return new Vector3((float)(Math.Cos(angle)*distance), 0, (float)(Math.Sin(angle)*distance));
    }
}
