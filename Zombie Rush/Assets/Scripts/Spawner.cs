using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    Camera cam;
    public bool isVisible;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPos = cam.WorldToScreenPoint(transform.position);
        bool onScreen = screenPos.x > 0f && screenPos.x < UnityEngine.Device.Screen.width && screenPos.y > 0f && screenPos.y < UnityEngine.Device.Screen.height;

        if (onScreen && GetComponent<MeshRenderer>().isVisible)
        {
            //Visible
            isVisible = true;
        }
        else
        {
            //NotVisible
            isVisible = false;
        }
    }
}
