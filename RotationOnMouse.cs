using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOnMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Mouse X");
        var y = Input.GetAxis("Mouse Y");

        transform.eulerAngles += new Vector3(y, -x, 0);
    }
}
