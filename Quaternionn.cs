using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Quaternionn : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public GameObject cubik;

    public void OnPointerClick(PointerEventData eventData)
    {
        cubik.transform.rotation = Quaternion.Euler(new Vector3(30, 30, 0));
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
