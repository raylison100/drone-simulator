using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];   

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Untagged")
        {
            AlterMaterial();
        }
    }

    public void AlterMaterial()
	{
        rend.sharedMaterial = material[1];
        print("PASSOU");
    }
}
