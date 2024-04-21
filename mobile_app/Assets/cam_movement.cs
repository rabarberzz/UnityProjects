using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_movement : MonoBehaviour
{

    private Touch touch;
    private Quaternion rotationY;
    public float rotationSpeedModifier = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(touch.deltaPosition.y * rotationSpeedModifier, touch.deltaPosition.x * rotationSpeedModifier, 0f);

                transform.rotation = rotationY * transform.rotation;
            }
        } 
    }
}
