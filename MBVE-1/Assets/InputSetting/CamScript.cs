using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class CamScript : MonoBehaviour
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
    public GameObject Browser1;
    public GameObject Browser2;
    public GameObject Browser3;
    public GameObject Browser4;
    public GameObject Browser5;
    public GameObject Browser6;
    public GameObject Browser7;
    public GameObject Browser8;
    public GameObject Browser9;

    /*   void Start()
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

       void Update()
       {

           if (Input.GetMouseButtonDown(0))
           { 
           Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
               RaycastHit hit;

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
               if (Physics.Raycast(ray, out hit))
               {

                   if (hit.collider.gameObject.name == "Browser1")
                       CamRTS.SetActive(false); 
                       Cam1.SetActive(true);
                       Cam2.SetActive(false);
                       Cam3.SetActive(false);
                       Cam4.SetActive(false);
                       Cam5.SetActive(false);
                       Cam6.SetActive(false);
                       Cam7.SetActive(false);
                       Cam8.SetActive(false);
                       Cam9.SetActive(false);
                   if (hit.collider.gameObject.name == "Browser2")
                       CamRTS.SetActive(false);
                       Cam1.SetActive(false);
                       Cam2.SetActive(true);
                       Cam3.SetActive(false);
                       Cam4.SetActive(false);
                       Cam5.SetActive(false);
                       Cam6.SetActive(false);
                       Cam7.SetActive(false);
                       Cam8.SetActive(false);
                       Cam9.SetActive(false);
                   if(hit.collider.gameObject.name == "Browser3")
                       CamRTS.SetActive(false);
                       Cam1.SetActive(false);
                       Cam2.SetActive(false);
                       Cam3.SetActive(true);
                       Cam4.SetActive(false);
                       Cam5.SetActive(false);
                       Cam6.SetActive(false);
                       Cam7.SetActive(false);
                       Cam8.SetActive(false);
                       Cam9.SetActive(false);
                   if(hit.collider.gameObject.name == "Browser4")
                       CamRTS.SetActive(false);
                       Cam1.SetActive(false);
                       Cam2.SetActive(false);
                       Cam3.SetActive(false);
                       Cam4.SetActive(true);
                       Cam5.SetActive(false);
                       Cam6.SetActive(false);
                       Cam7.SetActive(false);
                       Cam8.SetActive(false);
                       Cam9.SetActive(false);
                   if (hit.collider.gameObject.name == "Browser5")
                       CamRTS.SetActive(false);
                       Cam1.SetActive(false);
                       Cam2.SetActive(false);
                       Cam3.SetActive(false);
                       Cam4.SetActive(false);
                       Cam5.SetActive(true);
                       Cam6.SetActive(false);
                       Cam7.SetActive(false);
                       Cam8.SetActive(false);
                       Cam9.SetActive(false);
                   if (hit.collider.gameObject.name == "Browser6")
                       CamRTS.SetActive(false);
                       Cam1.SetActive(false);
                       Cam2.SetActive(false);
                       Cam3.SetActive(false);
                       Cam4.SetActive(false);
                       Cam5.SetActive(false);
                       Cam6.SetActive(true);
                       Cam7.SetActive(false);
                       Cam8.SetActive(false);
                       Cam9.SetActive(false);
                   if(hit.collider.gameObject.name == "Browser7")
                       CamRTS.SetActive(false);
                       Cam1.SetActive(false);
                       Cam2.SetActive(false);
                       Cam3.SetActive(false);
                       Cam4.SetActive(false);
                       Cam5.SetActive(false);
                       Cam6.SetActive(false);
                       Cam7.SetActive(true);
                       Cam8.SetActive(false);
                       Cam9.SetActive(false);
                   if (hit.collider.gameObject.name == "Browser8")
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
                   if (hit.collider.gameObject.name == "Browser9")
                       CamRTS.SetActive(false);
                       Cam1.SetActive(false);
                       Cam2.SetActive(false);
                       Cam3.SetActive(false);
                       Cam4.SetActive(false);
                       Cam5.SetActive(false);
                       Cam6.SetActive(false);
                       Cam7.SetActive(false);
                       Cam8.SetActive(false);
                       Cam9.SetActive(true);

               }
           }
       }
    */


    void Update()
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
        
        if (Input.GetButtonDown("1Key"))
            {
                CamRTS.SetActive(false);
                Cam1.SetActive(true);
                Cam2.SetActive(false);
                Cam3.SetActive(false);
                Cam4.SetActive(false);
                Cam5.SetActive(false);
                Cam6.SetActive(false);
                Cam7.SetActive(false);
                Cam8.SetActive(false);
                Cam9.SetActive(false);
            }
            if (Input.GetButtonDown("2Key"))
            {
                CamRTS.SetActive(false);
                Cam1.SetActive(false);
                Cam2.SetActive(true);
                Cam3.SetActive(false);
                Cam4.SetActive(false);
                Cam5.SetActive(false);
                Cam6.SetActive(false);
                Cam7.SetActive(false);
                Cam8.SetActive(false);
                Cam9.SetActive(false);
            }
            if (Input.GetButtonDown("3Key"))
            {
                CamRTS.SetActive(false);
                Cam1.SetActive(false);
                Cam2.SetActive(false);
                Cam3.SetActive(true);
                Cam4.SetActive(false);
                Cam5.SetActive(false);
                Cam6.SetActive(false);
                Cam7.SetActive(false);
                Cam8.SetActive(false);
                Cam9.SetActive(false);
            }
            if (Input.GetButtonDown("4Key"))
            {
                CamRTS.SetActive(false);
                Cam1.SetActive(false);
                Cam2.SetActive(false);
                Cam3.SetActive(false);
                Cam4.SetActive(true);
                Cam5.SetActive(false);
                Cam6.SetActive(false);
                Cam7.SetActive(false);
                Cam8.SetActive(false);
                Cam9.SetActive(false);
            }
            if (Input.GetButtonDown("5Key"))
            {
                CamRTS.SetActive(false);
                Cam1.SetActive(false);
                Cam2.SetActive(false);
                Cam3.SetActive(false);
                Cam4.SetActive(false);
                Cam5.SetActive(true);
                Cam6.SetActive(false);
                Cam7.SetActive(false);
                Cam8.SetActive(false);
                Cam9.SetActive(false);
            }
            if (Input.GetButtonDown("6Key"))
            {
                CamRTS.SetActive(false);
                Cam1.SetActive(false);
                Cam2.SetActive(false);
                Cam3.SetActive(false);
                Cam4.SetActive(false);
                Cam5.SetActive(false);
                Cam6.SetActive(true);
                Cam7.SetActive(false);
                Cam8.SetActive(false);
                Cam9.SetActive(false);
            }
            if (Input.GetButtonDown("7Key"))
            {
                CamRTS.SetActive(false);
                Cam1.SetActive(false);
                Cam2.SetActive(false);
                Cam3.SetActive(false);
                Cam4.SetActive(false);
                Cam5.SetActive(false);
                Cam6.SetActive(false);
                Cam7.SetActive(true);
                Cam8.SetActive(false);
                Cam9.SetActive(false);
            }
            if (Input.GetButtonDown("8Key"))
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
            if (Input.GetButtonDown("9Key"))
            {
                CamRTS.SetActive(false);
                Cam1.SetActive(false);
                Cam2.SetActive(false);
                Cam3.SetActive(false);
                Cam4.SetActive(false);
                Cam5.SetActive(false);
                Cam6.SetActive(false);
                Cam7.SetActive(false);
                Cam8.SetActive(false);
                Cam9.SetActive(true);
            }
        }
    

}
