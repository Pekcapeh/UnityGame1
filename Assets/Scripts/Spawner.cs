using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameObject CoinPrefab;
    public float StartTimeBtwStart;

    private int YSpawnPosition = -4;
    private float _timeBtwStart = 0;

    void Update()
    {
        Random random = new Random();

        if (_timeBtwStart <= 0)
        {
            int rand = Random.Range(0, 10);

            if (rand < 7)
            {
                Instantiate(CoinPrefab, new Vector2(transform.position.x, YSpawnPosition + 1), Quaternion.identity);
            }
            else
            {
                Instantiate(EnemyPrefab, new Vector2(transform.position.x, YSpawnPosition), Quaternion.identity);
            }

            _timeBtwStart = StartTimeBtwStart;
        }
        else
        {
            _timeBtwStart -= Time.deltaTime;
        }
    }
}
