using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour //MonoBehaviour class that is a class that exict in UnityEngine
{

    //private string awakeMessage = "defult message";//camelcase
    //one time as long aqs the object is enabled

    public Vector2 aVector2;
    public Vector3 aVector3;

    public double aDouble;
    public float aFloat;

    public char aChar;
    public bool aBool;

    public int incrementer;
    void Awake() {

       // awakeMessage = "I'm awake 2.0"; //assigining new message
        Debug.Log(aVector2);
        Debug.Log(aVector3);
    
    }
    
    
    // Start is called before the first frame update
    void Start() {

        Debug.Log(aDouble);
        Debug.Log(aFloat);

        //Debug.Log("Lets get started");
    }

    // Update is called once per frame
    void Update() { //like a loop

        Debug.Log(aChar);
        Debug.Log(aBool);
        incrementer = incrementer + 1;
        Debug.Log(incrementer);
             
        //Debug.Log("Hello world");

    }
}//class
