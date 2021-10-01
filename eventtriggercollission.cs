using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class eventtriggercollission : MonoBehaviour
{

    public UnityEngine.Events.UnityEvent m_MyEvent;

    void OnTriggerEnter2D(Collider2D player){
        if (player.tag.Equals("Player")){
            m_MyEvent.Invoke();
        }
    }

}