using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private float Speed = 13;
    void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
    }
}
