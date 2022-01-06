using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimationController : MonoBehaviour
{
    public Animator anim;
    
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
             anim.SetBool("isDancing", true);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.CompareTag("Player")){
             anim.SetBool("isDancing", false);
        }
    }
}
