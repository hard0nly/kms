using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task14 : MonoBehaviour
{
    [SerializeField]
    public GameObject Cub;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.transform.GetComponent<Rigidbody>().useGravity = false;
        other.transform.GetComponent<Rigidbody>().isKinematic = true;
        other.transform.Rotate(new Vector3(20, 0, 0));
    }
}
