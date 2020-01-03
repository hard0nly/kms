using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(Random.Range(5f, -5f), Random.Range(1f, 10f), Random.Range(5f, -5f));
            cube.transform.localScale = new Vector3(1f, 1f, 1f);
            cube.AddComponent<Rigidbody>();
        }
    }
}
