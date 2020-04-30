using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showDamage : MonoBehaviour
{

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();   
    }

    public void theHit()
    {
        anim.SetTrigger("hit");
    }


}
