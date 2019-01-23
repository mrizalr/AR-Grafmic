using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour {

    private bool rotateX, rotateY, rotateZ = false;
    public Text rotateAxis;
    public Text rotateSyntax;
    float angle = 2f;

	// Use this for initialization
	void Start () {
		rotateY = rotateZ = false;
        rotateX = true;
        rotateAxis.text = "Rotasi Sumbu X";
        rotateSyntax.text = "- glRotatef(45.,1.,0.,0.); -";
    }
	
	// Update is called once per frame
	void Update () {
        if (rotateX)
        {
            transform.Rotate(new Vector3(angle, 0, 0));
            rotateAxis.text = "Rotasi Sumbu X";
            rotateSyntax.text = "- glRotatef(45.,1.,0.,0.); -";
        }
        else if (rotateY)
        {
            transform.Rotate(new Vector3(0, angle, 0));
            rotateAxis.text = "Rotasi Sumbu Y";
            rotateSyntax.text = "- glRotatef(45.,0.,1.,0.); -";
        }
        else if (rotateZ)
        {
            transform.Rotate(new Vector3(0, 0, angle));
            rotateAxis.text = "Rotasi Sumbu Z";
            rotateSyntax.text = "- glRotatef(45.,0.,0.,1.); -";
        }
	}

    public void RotateXAxis()
    {
        Vector3 temp = transform.rotation.eulerAngles;
        temp.y = 0f;
        temp.z = 0f;
        transform.rotation = Quaternion.Euler(temp);
        rotateX = true;
        rotateY = rotateZ = false;
    }

    public void RotateYAxis()
    {
        Vector3 temp = transform.rotation.eulerAngles;
        temp.x = 0f;
        temp.z = 0f;
        transform.rotation = Quaternion.Euler(temp);
        rotateY = true;
        rotateX = rotateZ = false;
    }

    public void RotateZAxis()
    {
        Vector3 temp = transform.rotation.eulerAngles;
        temp.x = 0f;
        temp.y = 0f;
        transform.rotation = Quaternion.Euler(temp);
        rotateZ = true;
        rotateX = rotateY = false;
    }
}
