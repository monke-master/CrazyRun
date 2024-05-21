using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Vector3 GetTouchDeltaPosition()
    {
        if (Input.touchCount > 0)
        {
            var vector2 = Input.GetTouch(0).deltaPosition;
            return new Vector3(vector2.x, 0, vector2.y);
        }
        return Vector3.zero;
    }

    public bool IsTouch()
    {
        return Input.touchCount > 0;
    }
}
