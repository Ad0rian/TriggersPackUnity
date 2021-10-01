using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windTrigger : MonoBehaviour
{
    public Animator animator;
    public UnityEngine.Events.UnityEvent EnL_MyEvent;
    public UnityEngine.Events.UnityEvent ExL_MyEvent;
    public UnityEngine.Events.UnityEvent EnR_MyEvent;
    public UnityEngine.Events.UnityEvent ExR_MyEvent;

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag.Equals("WindLeft")){
            animator.SetBool("isShakingLeft", true);
            EnL_MyEvent.Invoke();
            
        }
        if (collision.tag.Equals("WindRight")){
            animator.SetBool("isShakingRight", true);
            EnR_MyEvent.Invoke();
        }
    }
    void OnTriggerExit2D(Collider2D collision){
        if (collision.tag.Equals("WindLeft")){
            animator.SetBool("isShakingLeft", false);
            ExL_MyEvent.Invoke();
        }
        if (collision.tag.Equals("WindRight")){
            animator.SetBool("isShakingRight", false);
            ExR_MyEvent.Invoke();
        }
    }

}
