using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bin1Trigger : MonoBehaviour
{
    private int counter = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Plastic"))
        {
            counter++;
            Debug.Log("Plastic bin: " + counter + " pieces of trash.");
        } else {
            Debug.Log("Not plastic");
        }
    }
}