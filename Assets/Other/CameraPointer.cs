using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPointer : MonoBehaviour
{
    public Transform portal;

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = portal.position - player.position;
        difference = new Vector3(difference.x,0,difference.z);
        transform.LookAt(transform.position + difference);
    }
}
