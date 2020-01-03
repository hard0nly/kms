using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task219 : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            var pos = transform.position;
            pos.y = Mathf.Clamp(transform.position.y + 0.2f, -1, 3);
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.S))
        {
            var pos = transform.position;
            pos.y = Mathf.Clamp(transform.position.y - 0.2f, -1, 3);
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.A))
        {
            var pos = transform.position;
            pos.x = Mathf.Clamp(transform.position.x - 0.2f, -3, 3);
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.D))
        {
            var pos = transform.position;
            pos.x = Mathf.Clamp(transform.position.x - 0.2f, -3, 3);
            transform.position = pos;
        }
        if (Input.GetAxis("Mouse X") != 0)
        {
            transform.RotateAround(cube.transform.position, Vector3.up, Input.GetAxis("Mouse X") * 2);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            var sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.AddComponent<Rigidbody>();
            sphere.GetComponent<Rigidbody>().useGravity = true;
            sphere.transform.localScale = new Vector3(1, 1, 1);
            sphere.transform.position = new Vector3(Random.Range(1, 2), Random.Range(1, 2), Random.Range(1, 2));
        }
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            var pos = transform.position + transform.TransformDirection(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * 2);
            Debug.Log(pos);
            if (pos.z < -7 && pos.z > -10) transform.position = pos;
        }
    }
}
