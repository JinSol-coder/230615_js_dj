using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    int step = 0;
    void Update()
    {
        float posX = this.transform.position.x;
        float posY = this.transform.position.y;

        if (posY >= 2f)
        {
            step = 1;
        }
        if (posY >= 2f && posX >= 2f)
        {
            step = 2;
        }
        if (posY <= -2f && posX >= 2f)
        {
            step = 3;
        }
        if (posY <= -2f && posX <= -2f)
        {
            step = 0;
        }



        switch (step)
        {
            case 0:
                this.transform.position += new Vector3(0, 2f * Time.deltaTime, 0);
                break;
            case 1:
                this.transform.position += new Vector3(2f * Time.deltaTime, 0, 0);
                break;
            case 2:
                this.transform.position += new Vector3(0, -2f * Time.deltaTime, 0);
                break;
            case 3:
                this.transform.position += new Vector3(2f * Time.deltaTime, 0, 0);
                break;

        }
    }
}
