using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private Vector3 move;

    private void Awake()
    {
        move = new Vector3(_moveSpeed, 0, 0);
    }

    private void Update()
    {
        transform.Translate(move);
    }
}
