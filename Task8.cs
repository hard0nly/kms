using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task8 : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 randPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(1f, 10f), Random.Range(-5f, 5f));
            var clone = Instantiate(prefab, randPosition, Quaternion.identity);
            if (clone.transform.position.y <= 1) Destroy(clone);
        }
    }
}
