using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shifter : MonoBehaviour
{
    public GameObject Red;
    public GameObject Blue;

    bool RedUp = true;
    bool redGoingDown = false;
    bool redGoingUp = false;
    bool blueGoingDown = false;
    bool blueGoingUp = false;

    public Transform upPosition;
    public Transform downPosition;
    Vector3 upPositionOffset;
    Vector3 downPositionOffset;

    public GameObject[] redGameObjects;
    public GameObject[] blueGameObjects;

    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //upPosition.position = transform.position + upPositionOffset;
       // downPosition.position = transform.position + downPositionOffset;
        if(Input.GetKeyDown(KeyCode.L))
        {
            if(!redGoingDown && !redGoingUp && !blueGoingDown && !blueGoingUp)
            {
                if(RedUp)
                {
                    redGoingDown = true;
                }
                else
                {
                    blueGoingDown = true;
                }
            }
        }
        if(redGoingDown)
        {
            Red.transform.position = Vector3.Lerp(Red.transform.position, downPosition.position, speed);
            if(Vector3.Distance(Red.transform.position,downPosition.position) < 0.1f)
            {
                Red.transform.position = downPosition.position;
                blueGoingUp = true;
                redGoingDown = false;
                for(int i = 0; i < blueGameObjects.Length; i++)
                {
                    blueGameObjects[i].SetActive(true);
                }
                for (int i = 0; i < redGameObjects.Length; i++)
                {
                    redGameObjects[i].SetActive(false);
                }
            }
        }

        if (redGoingUp)
        {
            Red.transform.position = Vector3.Lerp(Red.transform.position, upPosition.position, speed);
            if (Vector3.Distance(Red.transform.position, upPosition.position) < 0.1f)
            {
                Red.transform.position = upPosition.position;
                redGoingUp = false;
                RedUp = true;
            }
        }

        if (blueGoingDown)
        {
            Blue.transform.position = Vector3.Lerp(Blue.transform.position, downPosition.position, speed);
            if (Vector3.Distance(Blue.transform.position, downPosition.position) < 0.1f)
            {
                Blue.transform.position = downPosition.position;
                redGoingUp = true;
                blueGoingDown = false;
                for (int i = 0; i < blueGameObjects.Length; i++)
                {
                    blueGameObjects[i].SetActive(false);
                }
                for (int i = 0; i < redGameObjects.Length; i++)
                {
                    redGameObjects[i].SetActive(true);
                }
            }
        }

        if (blueGoingUp)
        {
            Blue.transform.position = Vector3.Lerp(Blue.transform.position, upPosition.position, speed);
            if (Vector3.Distance(Blue.transform.position, upPosition.position) < 0.1f)
            {
                Blue.transform.position = upPosition.position;
                blueGoingUp = false;
                RedUp = false;
            }
        }
    }
}
