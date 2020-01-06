using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(GroundChecker))]

public class Player : MonoBehaviour
{
    public TMP_Text Text;

    private int _health = 1;
    private float _speedRotation = 10;
    private float _jumpForce = 20;    
    private int _money = 0;
    private Rigidbody2D _rigidbody;
    private GroundChecker _groundChecker;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _groundChecker = GetComponent<GroundChecker>();
    }

    private void Update()
    {        
        transform.Rotate(new Vector3(0, 0, -_speedRotation) * 100 * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _groundChecker.CheckGround())
        {
            _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    public void ApplyDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
            SceneManager.LoadScene("Menu");
    }

    public void AddMoney(int money)
    {
        _money += money;
        Text.text = _money.ToString();
    }
}
