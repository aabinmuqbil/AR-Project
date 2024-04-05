using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class GameActionManager : MonoBehaviour
{
    bool walk = false;
    bool sit = false;
    public Animator animator;
    public GameObject gameObject;
    //public GameObject foxObj;
   // public ARTrackedImageManager imageManager;



    // Start is called before the first frame update
    //Fox(Clone)
    public void WalkActive()
    {
        //GameObject.Find("Fox(Clone)").GetComponent<Animator>
        //GameObject foxObjClone = Fox(Clone);
        gameObject.SetActive(true);
       // walk = true;
       // animator.SetBool("WalkFront", true);
        
    }
    public void SitActive()
    {
        sit = true;
        animator.SetBool("WalkFront", false);
        animator.SetBool("Sit", true);
    }

    public void activateObject()
    {
        gameObject.SetActive(true);
    }
}
