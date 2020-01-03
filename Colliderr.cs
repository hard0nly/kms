using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliderr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var quat = Quaternion.Euler(new Vector3(5, 5, 5));
        transform.rotation *= quat;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("wuf");
    }
}
