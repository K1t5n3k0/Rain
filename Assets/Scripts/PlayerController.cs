using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("===== Key settings=====")]
    public string KeyUp = "w";
    public string KeyDown = "s";
    public string KeyLeft = "a";
    public string KeyRight = "d";

    public string KeyA = "left shift";
    public string KeyB = "c";
    public string KeyC = "space";
    public string KeyD;

    [Header("=====Output signals=====")]
    public float Dup;
    public float Dright;
    public float Dmag;
    public Vector3 Dvec;
    //1.pressing signal
    public bool run;
    //2.trigger signal
    public bool roll;
    public bool jump;
    private bool lastJump;
    //3.double sognal

    [Header("=====Others=====")]
    public bool SWITCH = true;

    public float targetDup;
    public float targetDright;
    public float velocityDup;
    public float velocityDright;

    // Update is called once per frame
    void Update()
    {
    
    }
}
