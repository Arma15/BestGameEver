using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : MonoBehaviour
{


    public Vector3 pos;
    public Vector3 ang;
    int dir = 1;


    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        float x = pos.x;
        float y = pos.y;
        float z = pos.z;

        ang = transform.localEulerAngles;
        float angleX = ang.x;
        float angleY = ang.y;
        float angleZ = ang.z;

        Debug.Log("Laser Gun translation coords ("+x+","+y+","+z+")");
        Debug.Log("Laser Gun rotation coords (" + angleX + "," + angleY + "," + angleZ + ")");

    }

    // Update is called once per frame
    void Update()
    {

        if(dir == 1)
        {//Clockwise
            transform.Rotate(0, 0, 0.8f);//Rotate gun clockwise
            Camera.main.transform.Rotate(0, 0.8f, 0);//Rotate camera clockwise
        }
        else
        {
            transform.Rotate(0, 0, -0.8f);//Rotate camera counterclockwise
            Camera.main.transform.Rotate(0, -0.8f, 0);
        }

        //Update the angles
        ang = transform.localEulerAngles;
        float angleX = ang.x;
        float angleY = ang.y;
        float angleZ = ang.z;

        if(angleZ >= 180)
        {
            dir = -1;//Counter clockwise
        }
        if (angleZ <= 120)
        {
            dir = 1;//Counter clockwise
        }


        //Debug.Log("Laser Gun rotation coords (" + angleX + "," + angleY + "," + angleZ + ")");
    }
}
