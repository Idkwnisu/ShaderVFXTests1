using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerDepthMaterialSetter : MonoBehaviour
{
    private Renderer rend;
    private Material mat;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        mat = rend.material;
    }

    // Update is called once per frame
    void Update()
    {
        mat.SetVector("_Forward", transform.forward);
        mat.SetVector("_Up", transform.up);
    }
}
