using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationPlayTrigger : MonoBehaviour
{
    // Start is called before the first frame update
     public Animator[] animator;
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D player){
    if (player.tag.Equals("Player")){
        foreach(Animator anim in animator)
        {
            anim.SetBool("PlayAnimation", true);
            
        }
    }

}
    void OnTriggerExit2D(Collider2D player){
        foreach(Animator anim in animator)
        {
            anim.SetBool("PlayAnimation", false);
            
        }
    }
}
