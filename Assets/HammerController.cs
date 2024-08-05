using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HammerController : MonoBehaviour
{

    public Text textUI;
    int max = 5;
    public ontroller mainBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionStay(Collision collision) {
        if(max < collision.impulse.y) { 
            mainBox.setHammer(); }
            //max = (int)collision.impulse.y;
        textUI.text = "" + collision.impulse.y;
    }

    private void OnCollisionExit(Collision collision) {
        max = -1;
    }

}
