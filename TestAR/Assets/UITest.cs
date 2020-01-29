using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class UITest : MonoBehaviour
{
    public Text instructions;
    int aux;

    public bool GroundPlaneHitReceived { get; private set; }

    public void OnAutomaticHitTest(HitTestResult result)
    {
        aux = Time.frameCount;
        //if (result==null)
        //{
        //    instructions.text = "Point device towards ground";
        //}
        //else
        //{
        //    instructions.color = Color.green;
        //    instructions.text = "Plane Found";
        //}

        //Debug.Log(result.ToString());
    }

    public void Probando()
    {
        instructions.text = "Point device towards ground";
    }
    void LateUpdate()
    {
        GroundPlaneHitReceived = (this.aux == Time.frameCount);
        if (GroundPlaneHitReceived )
        {
            instructions.color = Color.green;
            instructions.text = "Plane Found";
        }
        else
        {
            instructions.color = Color.red;
            instructions.text = "Point device towards ground";
        }
        //Debug.Log(GroundPlaneHitReceived);
    }

   
}
