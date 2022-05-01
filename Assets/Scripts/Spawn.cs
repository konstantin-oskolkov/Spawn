using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Enemy EnemyPrefab;
    public float TimeToSpawn;

    private float timer;

    void Start()
    {
        timer = TimeToSpawn;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Enemy enemy = Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
            timer = TimeToSpawn;
        }
    }
}
