using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterTriggerEnemies : MonoBehaviour
{
    public string objectCollide;
    public UnityEngine.Events.UnityEvent m_MyEvent;

    void OnTriggerEnter2D(Collider2D objectCollide){
        if (objectCollide.tag.Equals("EnemyTrigger")){
            m_MyEvent.Invoke();
        }
    }

    void Ping()
    {

    }
}
