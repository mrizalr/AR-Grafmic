using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class Translation : MonoBehaviour {

    private bool xAxis, yAxis, zAxis = false;
    public Text translationAxis;
    public Text translationSyntax;
    public Animator myAnimator;

	// Use this for initialization
	void Start () {
        yAxis = zAxis = false;
        xAxis = true;
        translationAxis.text = "Translasi sumbu X";
        translationSyntax.text = "- glTranslatef(1.,0.,0.); -";
	}
	
	// Update is called once per frame
	void Update () {
        
        if (xAxis)
        {
            myAnimator.Play("XAxisTranslation");
            translationAxis.text = "Translasi sumbu X";
            translationSyntax.text = "- glTranslatef(1.,0.,0.); -";
        }
        else if (yAxis)
        {
            myAnimator.Play("YAxisTranslation");
            translationAxis.text = "Translasi sumbu Y";
            translationSyntax.text = "- glTranslatef(0.,1.,0.); -";
        }
        else if (zAxis)
        {
            myAnimator.Play("ZAxisTranslation");
            translationAxis.text = "Translasi sumbu Z";
            translationSyntax.text = "- glTranslatef(0.,0.,1.); -";
        }
    }

    public void translasiXAxis()
    {
        xAxis = true;
        yAxis = zAxis = false;
    }

    public void translasiYAxis()
    {
        yAxis = true;
        xAxis = zAxis = false;
    }

    public void translasiZAxis()
    {
        zAxis = true;
        xAxis = yAxis = false;
    }
}
