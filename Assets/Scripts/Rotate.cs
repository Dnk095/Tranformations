using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private void FixedUpdate()
    {
        transform.Rotate(0, _rotateSpeed, 0);
    }
}
