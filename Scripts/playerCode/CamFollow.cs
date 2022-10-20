using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject MainCam;
    public Transform PlayerTransform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(PlayerTransform.position.x, PlayerTransform.position.y+20, PlayerTransform.position.z-17.5f);
        /*
        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.transform.Rotate(Vector3.up, 45);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.transform.Rotate(Vector3.up, -45);
        }
        */
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (MainCam.GetComponent<Camera>().fieldOfView > 50)
                MainCam.GetComponent<Camera>().fieldOfView--;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (MainCam.GetComponent<Camera>().fieldOfView < 70)
                MainCam.GetComponent<Camera>().fieldOfView++;
        }
    }
}
