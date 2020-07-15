using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnAround : MonoBehaviour
{
    public Transform center;

    public float speed;

    public float distance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(center.position.x + Mathf.Cos(Time.time*speed)*distance, center.position.y,center.position.z + Mathf.Sin(Time.time*speed)*distance );
    }
}
