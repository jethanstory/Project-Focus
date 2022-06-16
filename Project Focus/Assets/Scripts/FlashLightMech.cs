//Flashlight mechanic for FPS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightMech : MonoBehaviour
{
    public bool isOn = false;
    public bool isView = false;
    public GameObject lightSource;
    public GameObject viewSource;

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("FKey"))
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isOn == false)
                {
                    lightSource.SetActive(true);
                    isOn = true;
                }

            else if (isOn == true)
            {
                lightSource.SetActive(false);
                isOn = false;
            }
            
        } 
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (isView == false)
                {
                    viewSource.SetActive(true);
                    isView = true;
                }

            else if (isView == true)
            {
                viewSource.SetActive(false);
                isView = false;
            }
            
        } 
    }
}
