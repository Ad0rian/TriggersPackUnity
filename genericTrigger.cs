using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genericTrigger : MonoBehaviour
{
    public string tagCollide;
    public UnityEngine.Events.UnityEvent En_MyEvent;
    public UnityEngine.Events.UnityEvent Ex_MyEvent;

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag.Equals(tagCollide)){
            En_MyEvent.Invoke();
        }
    }
    void OnTriggerExit2D(Collider2D collision){
        if (collision.tag.Equals(tagCollide)){
            Ex_MyEvent.Invoke();
        }
    }


}
