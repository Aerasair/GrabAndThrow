using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] private float _scaleFactor;

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.TryGetComponent(out Cheese cheese))
        {
            transform.localScale = new Vector3(transform.localScale.x * _scaleFactor, transform.localScale.y * _scaleFactor, transform.localScale.z * _scaleFactor);
        }
    }
}
