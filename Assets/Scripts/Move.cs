using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private void FixedUpdate()
    {
        var NextPosition = transform.position;
        NextPosition.x += _moveSpeed;
        transform.position = NextPosition;
    }
}
