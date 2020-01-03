using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task13 : MonoBehaviour
{
    [SerializeField]
    public GameObject Cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cube.transform.position -= new Vector3(0.1f, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");
        other.gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }
}
