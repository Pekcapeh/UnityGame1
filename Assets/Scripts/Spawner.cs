using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private GameObject _coinPrefab;
    private float _startTimeSpawn = 0.7f;
    private float _timeSpawn = 0;
    private float _xSpawnPosition;
    private float _yAirSpawnPosition;
    private float _yGroundSpawnPosition;    

    private void Start()
    {
        _xSpawnPosition = GetComponent<Transform>().position.x;
        _yGroundSpawnPosition = GetComponent<Transform>().position.y;
        _yAirSpawnPosition = _yGroundSpawnPosition + 1;
    }

    void Update()
    {
        if (_timeSpawn <= 0)
        {
            int rand = Random.Range(0, 101);

            if (rand < 70)
            {
                SpawnTemplate(_coinPrefab, _xSpawnPosition, _yAirSpawnPosition);
            }
            else
            {
                SpawnTemplate(_enemyPrefab, _xSpawnPosition , _yGroundSpawnPosition);
            }

            _timeSpawn = _startTimeSpawn;
        }
        else
        {
            _timeSpawn -= Time.deltaTime;
        }
    }

    static void SpawnTemplate(GameObject prefab, float xPosition, float yPosition)
    {
        Instantiate(prefab, new Vector2(xPosition, yPosition), Quaternion.identity);
    }
}
