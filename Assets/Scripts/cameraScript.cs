using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    private float movementSpeed = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis ("Horizontal");
        float v = Input.GetAxis ("Vertical");

        GameObject thisObj = this.gameObject;
        Vector3 thisPos = thisObj.transform.position;
        thisPos.x += (h + v) * movementSpeed;
        thisPos.z += (v - h) * movementSpeed;
        thisObj.transform.position = thisPos;
    }
}
