using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void FixedUpdate()
    {
        Vector3 _newScale;

        _newScale = new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed);

        transform.localScale += _newScale;
    }
}
