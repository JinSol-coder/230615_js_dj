using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject Player;

    int step;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(step == 1)
        {
            if(Player.transform.position.x <= -2f)
            {
                step = 0;
            }
            else
            {
                Player.transform.position += new Vector3(-3 * Time.deltaTime, 0, 0);
            }
            
        }
        else if (step == 2)
        {
            if (Player.transform.position.x >= 2f)
            {
                step = 0;
            }
            else
            {
                Player.transform.position += new Vector3(3 * Time.deltaTime, 0, 0);
            }
        }
    }

    public void LeftMove()
    {
        step = 1;
        
    }
    
    public void RightMove()
    {
        step = 2;
        
    }
}
