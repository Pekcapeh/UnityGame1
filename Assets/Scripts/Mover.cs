using UnityEngine;

[RequireComponent(typeof(Spawner))]
public class Mover : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    private float _speed = 13;
    private float _timeLife = 50;

    private void Start()
    {
        _spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
        TimerDestroyer();
        Destroyer();
    }

    private void TimerDestroyer()
    {
        _timeLife = _spawner.TimerDestroy(_timeLife, _speed);        
    }

    private void Destroyer()
    {
        if (_timeLife <= 0)
            Destroy(gameObject);
    }
}
