using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterTriggerEvent : MonoBehaviour
{
    public string objectCollide;
    public UnityEngine.Events.UnityEvent m_MyEvent;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D objectCollide){
        if (objectCollide.tag.Equals("EventTrigger")){
            m_MyEvent.Invoke();
        }
    }

    void Ping()
    {

    }
}
