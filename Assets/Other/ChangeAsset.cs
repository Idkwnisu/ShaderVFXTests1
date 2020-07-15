using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.LWRP;
using UnityEngine.SceneManagement;

public class ChangeAsset : MonoBehaviour
{
    UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset asset;
    public UnityEngine.Rendering.Universal.ScriptableRendererData dummyData;
    public UnityEngine.Rendering.Universal.ScriptableRendererData firstData;
    public UnityEngine.Rendering.Universal.ScriptableRendererData secondData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            dummyData.rendererFeatures.Clear();
            for (int i = 0; i < secondData.rendererFeatures.Count; i++)
            {
                dummyData.rendererFeatures.Add(secondData.rendererFeatures[i]);
            }
            Debug.Log("Changed dummy");
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            dummyData.rendererFeatures.Clear();
            for (int i = 0; i < firstData.rendererFeatures.Count; i++)
            {
                dummyData.rendererFeatures.Add(firstData.rendererFeatures[i]);
            }
            Debug.Log("Changed dummy");
        }
        
    }
}
