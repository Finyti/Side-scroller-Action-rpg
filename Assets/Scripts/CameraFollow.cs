using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float dumping;

    private Vector3 velocity = Vector3.zero;
    void Start()
    {
        
    }


    void Update()
    {
        Vector3 movePosition = new Vector3(target.position.x, 0, target.position.z) + offset;
        transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, dumping);
    }
}
