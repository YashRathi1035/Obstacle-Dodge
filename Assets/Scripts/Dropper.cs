using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timetowait = 2f;

    MeshRenderer mr;
    Rigidbody rb;

    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        mr.enabled = false;
        rb.useGravity = false;
    }
    void Update()
    {
        if(Time.time > timetowait)
        {
            mr.enabled = true;
            rb.useGravity = true;
        }
    }
}
