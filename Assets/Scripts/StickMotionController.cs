using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class StickMotionController : MonoBehaviour {

    public float MouseX = 0;
    public float MouseY = 0;

    public float RelativePos = 0;

    void Update () {
        //var mouseX = Input.GetAxis("Mouse X");
        //var mouseY = Input.GetAxis("Mouse Y");

        var mousePos = Input.mousePosition;

        var screenWidth = Screen.width;

        MouseX = mousePos.x;
        MouseY = mousePos.y;

        RelativePos = MouseX / screenWidth;

        //gameObject.transform.Rotate(-180 + RelativePos*360,0,0);
        gameObject.transform.rotation = Quaternion.Inverse(Quaternion.Euler(-180 + RelativePos * 360, 0, 0));
    }
}
