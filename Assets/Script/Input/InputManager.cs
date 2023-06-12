using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;
    private Vector3 lastPos;
    private Vector3 currentPos;
    private float timer;
    private float offsetTime;
    private object currentVector;

    //public Joystick joystick;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }



    //public Vector3 GetStickVec()
    //{
    //    return new Vector3(0, joystick.Horizontal, 0);
    //}


    //public float GetStickHorizontal()
    //{ 
    //    return joystick.Horizontal; 
    //}

    //public float GetStickVertical()
    //{ 
    //    return joystick.Vertical; 
    //}

}
