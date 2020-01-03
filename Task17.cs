using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Task17 : MonoBehaviour, IPointerClickHandler
{
    public GameObject panel;

    enum States 
    {
        Opened,
        Closed,
        Opening,
        Closing
    }

    States Statee;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Statee == States.Opened) Statee = States.Closing;
        if (Statee == States.Closed) Statee = States.Opening;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Statee == States.Closing)
        {
            var pos = panel.transform.position;
            pos.x += 10;
            panel.transform.position = pos;

            if (panel.transform.position.x >= 1060)
            {
                Statee = States.Closed;
                GetComponentInChildren<Text>().text = "Открыть";
            }
        }
        
        if (Statee == States.Opening)
        {
            var pos = panel.transform.position;
            pos.x -= 10;
            panel.transform.position = pos;

            if (panel.transform.position.x <= 800)
            {
                Statee = States.Opened;
                GetComponentInChildren<Text>().text = "Закрыть";
            }
        }
    }
}
