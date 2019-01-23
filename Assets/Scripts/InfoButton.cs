using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoButton : MonoBehaviour {

    public GameObject panelInformasi;
    int status=0;

	// Use this for initialization
	void Start () {
        panelInformasi.SetActive(false);
        status = 0;
	}
	
	public void InfoCall()
    {
        if (status == 0)
        {
            panelInformasi.SetActive(true);
            status = 1;
        }

        else if (status == 1)
        {
            panelInformasi.SetActive(false);
            status = 0;
        }
    }
}
