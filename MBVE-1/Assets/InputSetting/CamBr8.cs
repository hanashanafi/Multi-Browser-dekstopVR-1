using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBr8 : MonoBehaviour
{
    public GameObject CamRTS;
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;
    public GameObject Cam5;
    public GameObject Cam6;
    public GameObject Cam7;
    public GameObject Cam8;
    public GameObject Cam9;

    void OnMouseDown()
    {
        CamRTS.SetActive(false);
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(false);
        Cam5.SetActive(false);
        Cam6.SetActive(false);
        Cam7.SetActive(false);
        Cam8.SetActive(true);
        Cam9.SetActive(false);
    }

    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CamRTS.SetActive(true);
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
            Cam4.SetActive(false);
            Cam5.SetActive(false);
            Cam6.SetActive(false);
            Cam7.SetActive(false);
            Cam8.SetActive(false);
            Cam9.SetActive(false);
        }
    }*/


}
