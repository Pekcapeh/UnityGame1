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
                SpawnTemplate(CoinPrefab, _ySpawnPosition + 1);
            }
            else
            {
                SpawnTemplate(EnemyPrefab, _ySpawnPosition);
            }

            _timeSpawn = _startTimeSpawn;
        }
        else
        {
            _timeSpawn -= Time.deltaTime;
        }
    }

    static void SpawnTemplate(GameObject prefab, int yPosition)
    {
        Instantiate(prefab, new Vector2(prefab.transform.position.x, yPosition), Quaternion.identity);
    }
}
