using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.Play("door_3_open");
    }

    private void OnTriggerExit(Collider other)
    {
        anim.Play("door_3_close");
    }

    private void OnTriggerStay(Collider other)
    {
        anim.Play("door_3_opened");
    }
}
