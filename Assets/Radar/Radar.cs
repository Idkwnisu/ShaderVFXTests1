using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    public Material mat;
    private float _distance = 0.0f;
    public float speedDistance = 10;
    public float maxDistance = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _distance += speedDistance * Time.deltaTime;

        if(_distance > maxDistance)
        {
            _distance = 0.0f;
        }
        mat.SetFloat("Vector1_31BD5CA4", _distance);
    }
}
