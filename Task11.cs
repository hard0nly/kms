using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task11 : MonoBehaviour
{
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal += Input.GetAxis("Mouse X");
        vertical += Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(Mathf.Clamp(vertical, -90, 90), horizontal, 0);
    }
}
