using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowObject : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public bool useOffSetValues;
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        if (!useOffSetValues)
        {
            offset = target.position - transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        //target.Rotate(0, horizontal, 0);

        //float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        //target.Rotate(vertical, 0, 0);

        //float desireXAngle = target.eulerAngles.x;
        //float desireYAngle = target.eulerAngles.y;
        //Quaternion rotation = Quaternion.Euler(desireXAngle, desireYAngle, 0);

        //transform.position = target.position - (rotation * offset);
        transform.position = target.position - offset;
        transform.LookAt(target);
    }
}
