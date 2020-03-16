using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera PlayerView;
    public Camera BirdView;
    

    void Start()
    {
        PlayerView.enabled = true;
        BirdView.enabled = false;
    }

   
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            if (PlayerView.enabled == true)
            {
                PlayerView.enabled = false;
                BirdView.enabled = true;
            }
            else
            {
                PlayerView.enabled = true;
                BirdView.enabled = false;
            }
        }
            
    }
}
