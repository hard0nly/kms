using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task20 : MonoBehaviour
{
    public GameObject TargetPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            Vector3 newPos = transform.position + transform.TransformDirection(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * 2) * (-1);
            if (Control(Vector3.Distance(newPos, TargetPos.transform.position))) transform.position = newPos;
        }
        if (Input.GetAxis("Mouse X") != 0)
        {
            transform.RotateAround(TargetPos.transform.position, Vector3.up, Input.GetAxis("Mouse X") * 1);
        }
    }

    bool Control(float distance)
    {
        return distance > 3 && distance < 7;
    }
}
