using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task15_16 : MonoBehaviour
{
    //public AudioSource audioSource;
    public GameObject cube2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube2.transform.position -= new Vector3(0.1f, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<AudioSource>().Play();
        StartCoroutine(Lower(other.GetComponent<AudioSource>()));
    }

    IEnumerator Lower(AudioSource audio)
    {
        for (int i = 10; i >= 0; i--)
        {
            yield return new WaitForSeconds(0.5f);
            audio.volume -= 0.1f;
            Debug.Log(audio.volume);
        }
    }
}
