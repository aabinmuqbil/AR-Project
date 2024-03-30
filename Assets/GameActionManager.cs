using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameActionManager : MonoBehaviour
{
    bool walk = false;
    bool sit = false;
    public Animator animator;
    // Start is called before the first frame update

    public void WalkActive()
    {
        walk = true;
        animator.SetBool("WalkFront", true);
        
    }
    public void SitActive()
    {
        sit = true;
        animator.SetBool("WalkFront", false);
        animator.SetBool("Sit", true);
    }
}
