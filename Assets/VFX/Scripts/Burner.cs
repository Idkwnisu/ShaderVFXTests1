using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burner : MonoBehaviour
{
    Material mat;
    float burnEntity;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        burnEntity = Mathf.Sin(Time.time) * 0.7f + 0.6f;
        mat.SetFloat("_Point", burnEntity);
    }
}
