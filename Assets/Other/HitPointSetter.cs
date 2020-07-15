using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPointSetter : MonoBehaviour
{
    public Material lightMat;
    // Start is called before the first frame update
    void Start()
    {
        lightMat.SetVector("_HitPoint", new Vector3(0,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void setHitPoint(Vector3 hit,float distance)
    {
        lightMat.SetVector("_HitPoint", hit);
        lightMat.SetFloat("_Distance", distance / 18.0f * 2.2f + 0.8f);
    }
}
