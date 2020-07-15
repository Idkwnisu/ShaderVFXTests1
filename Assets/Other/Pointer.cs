using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    private HitPointSetter hitted;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if(hit.transform.gameObject.GetComponent<HitPointSetter>() != null)
            {
                if (Vector3.Distance(transform.position, hit.transform.position) < 18.0f)
                {
                    hitted = hit.transform.gameObject.GetComponent<HitPointSetter>();
                    hitted.setHitPoint(hit.point,hit.distance);
      
                }
                else
                {
                    if (hitted != null)
                    {
                        hitted.setHitPoint(Vector3.zero,3);
                        hitted = null;
                    }
                }
            }
            else
            {
                if (hitted != null)
                {
                    hitted.setHitPoint(Vector3.zero,3);
                    hitted = null;
                }
            }
        }
        else
        {
            if(hitted != null)
            {
                hitted.setHitPoint(Vector3.zero,3);
                hitted = null;
            }
        }
    }
}
