using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bin3Trigger : MonoBehaviour
{
    private int counter = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Metal"))
        {
            counter++;
            Debug.Log("Metal bin: " + counter + " pieces of trash.");
        } else {
            Debug.Log("Not metal");
        }
    }
}