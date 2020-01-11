using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private GameObject _coinPrefab;
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
                SpawnTemplate(_coinPrefab, _ySpawnPosition + 1);
            }
            else
            {
                SpawnTemplate(_enemyPrefab, _ySpawnPosition);
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
