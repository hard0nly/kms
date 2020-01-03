using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task19 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            var pos = transform.position;
            pos.y = Mathf.Clamp(transform.position.y + 1, -5, 5);
            transform.position = pos;
        } 

        if (Input.GetKey(KeyCode.DownArrow))
        {
            var pos = transform.position;
            pos.y = Mathf.Clamp(transform.position.y - 1, -5, 5);
            transform.position = pos;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            var pos = transform.position;
            pos.z = Mathf.Clamp(transform.position.z - 1, -15, 5);
            transform.position = pos;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            var pos = transform.position;
            pos.z = Mathf.Clamp(transform.position.z + 1, -15, 5);
            transform.position = pos;
        }
    }
}
