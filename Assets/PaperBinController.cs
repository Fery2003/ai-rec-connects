using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bin2Trigger : MonoBehaviour
{
    private int counter = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Paper"))
        {
            counter++;
            Debug.Log("Paper bin: " + counter + " pieces of trash.");
        } else {
            Debug.Log("Not paper");
        }
    }
}
