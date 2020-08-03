using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainScript : MonoBehaviour
{

    private float tileSize = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        InitGround();
        InitCamera();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitCamera() {
        GameObject camObj = GameObject.Find ("Main Camera");
        Vector3 camPos = camObj.transform.position;
        camPos.x += tileSize/2.0f;
        camPos.z += tileSize/2.0f;
        camObj.transform.position = camPos;
    }

    // build the basic ground tiles.
    void InitGround() 
    {
        GameObject groundObj = GameObject.Find ("GroundTile_0_0");
        Transform groundPos = groundObj.transform;

        for (int i=0; i<tileSize; i++) {
            for (int j=0; j<tileSize; j++) {
                GameObject newObj = Instantiate(groundObj);
                newObj.name = "GroundTile_"+i+"_"+j;
                Vector3 newPos = groundPos.position;
                newPos.x= i*1.0f;
                newPos.z= j*1.0f;
                newPos.y += Random.Range(-0.25f,0.25f);
                newObj.gameObject.transform.position = newPos;
            }
        }

    }
}
