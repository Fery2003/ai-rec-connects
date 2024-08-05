using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ontroller : MonoBehaviour
{

    bool firstPlug;
    bool secondPlug;
    bool thirdPlug;
    public Transform firstPoint;

    bool leverDown;
    public Transform secondPoint;


    bool hammerScore;
    public Transform thirdPoint;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void setFirstPlug()
    {
        firstPlug = true;
    }

    public void setSecondPlug()
    {
        secondPlug = true;
    }

    public void setThirdPlug()
    {
        thirdPlug = true;
    }

    public void setLever()
    {
        leverDown = true;
    }

    public void setHammer()
    {
        hammerScore = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (firstPlug && secondPlug && thirdPlug)
        {
            float step = 2 * Time.deltaTime;
            //First move
            transform.position = Vector3.Lerp(transform.position, firstPoint.position, step);

            if (leverDown)
            {

                //Second Move
                transform.position = Vector3.Lerp(transform.position, secondPoint.position, step);

                if (hammerScore)
                {

                    //Third and show final product
                    transform.position = Vector3.Lerp(transform.position, thirdPoint.position, step);

                }

            }

        }
        
        
    }
}
