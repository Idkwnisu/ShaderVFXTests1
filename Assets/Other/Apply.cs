using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apply : MonoBehaviour
{
    public Material mat;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        // Copy the source Render Texture to the destination,
        // applying the material along the way.
        Graphics.Blit(source, null, mat);
    }
}
