using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        transform.GetComponent<Renderer>().material.color = Color.red;
    }
}
