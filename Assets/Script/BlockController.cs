using UnityEngine;

public class BlockController : MonoBehaviour
{
    [SerializeField] float _speed;

    void Update()
    {
        transform.Translate(Vector2.up * (_speed * Time.deltaTime));
    }
}
