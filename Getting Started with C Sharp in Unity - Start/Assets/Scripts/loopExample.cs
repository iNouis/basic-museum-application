using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopExample : MonoBehaviour
{
    public int startingNumber;
    public string[] items;

    private void Awake()
    {
        //call my CountUpFromNumber method
        CountUpFromNumber(startingNumber);
        //call processItems
        ProcessItems();
    }

    void CountUpFromNumber(int myNumber) 
    {
        for (int recievedNumber = myNumber; recievedNumber <= 10; recievedNumber++) {
            Debug.Log(recievedNumber.ToString());
        
        }
        
    
    }

    //for each loop

    void ProcessItems()
    {

        foreach (string item in items)
        {

            Debug.Log(item);
        }
    }


}
