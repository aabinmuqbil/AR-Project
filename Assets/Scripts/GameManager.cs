using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private Camera arCamera;

    [SerializeField]
    private LayerMask layersToInclude;

    private GameObject foxController;

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
    }
    private void Update()
    {
        var activeTouches = UnityEngine.InputSystem.EnhancedTouch.Touch.activeTouches;
        if (activeTouches.Count > 0)
        {
            var touch = activeTouches[0];

            //bool isOverUI = touch.screenPosition.Is
        }
    }
}
