using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandAnimate : MonoBehaviour
{

    public ActionBasedController Hand;
    public Animator HandAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandAnimator.SetFloat("Grip", Hand.selectActionValue.action.ReadValue<float>());
        HandAnimator.SetFloat("Trigger", Hand.activateActionValue.action.ReadValue<float>());
    }
}
