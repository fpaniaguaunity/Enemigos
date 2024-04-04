using FPFInventory;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    CharacterController controller;
    Animator animator;
    FPSInventoryController fpsController = null;

    void Start()
    {
        controller = GetComponentInParent<CharacterController>();
        animator = GetComponentInParent<Animator>();
        fpsController = GetComponentInParent<FPSInventoryController>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("velocity", controller.velocity.magnitude);
    }
}
