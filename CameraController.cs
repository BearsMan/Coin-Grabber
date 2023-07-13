using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    Vector3 offSet;
    // Start is called before the first frame update
    void Start()
    {
        offSet = target.position - transform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = target.position - offSet;
    }
}
