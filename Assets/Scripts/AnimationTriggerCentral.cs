using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTriggerCentral : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerDance(Collider other){
        anim.SetBool("isDancing", true);
    }
    private void OnTriggerStop(Collider other){
        anim.SetBool("isDancing", false);
    }
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            anim.Play("hiphop");
        }
    }
}
