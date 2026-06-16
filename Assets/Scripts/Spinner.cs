using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float x = 0f;
    [SerializeField] float y = 1f;
    [SerializeField] float z = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(x, y, z);
    }
}
