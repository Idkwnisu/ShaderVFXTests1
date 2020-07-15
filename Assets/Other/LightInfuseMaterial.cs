using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightInfuseMaterial : MonoBehaviour
{
    public Material[] sssMaterials;
    private Light l;

    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        l = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0,1,0)*speed*Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0,-1,0)*speed*Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0,0,1)*speed*Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0,0,-1)*speed*Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.Q))
        {
            transform.position += new Vector3(-1,0,0)*speed*Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.position += new Vector3(1,0,0)*speed*Time.deltaTime;
        }
        for(int i = 0; i < sssMaterials.Length; i++)
        {
            sssMaterials[i].SetVector("_LightPos", transform.position);
            sssMaterials[i].SetColor("_LightColor", l.color);
        }
    }
}
