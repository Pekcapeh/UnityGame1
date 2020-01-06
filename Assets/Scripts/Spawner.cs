using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameObject CoinPrefab;

    private float _startTimeSpawn = 0.7f;
    private int _ySpawnPosition = -4;
    private float _timeSpawn = 0;

    void Update()
    {
        if (_timeSpawn <= 0)
        {
            int rand = Random.Range(0, 101);

            if (rand < 70)
            {
                Instantiate(CoinPrefab, new Vector2(transform.position.x, _ySpawnPosition + 1), Quaternion.identity);
            }
            else
            {
                Instantiate(EnemyPrefab, new Vector2(transform.position.x, _ySpawnPosition), Quaternion.identity);
            }

            _timeSpawn = _startTimeSpawn;
        }
        else
        {
            _timeSpawn -= Time.deltaTime;
        }
    }
}
