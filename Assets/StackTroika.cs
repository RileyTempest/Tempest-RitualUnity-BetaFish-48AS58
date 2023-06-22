using System.Collections;
using System.Collections.Generic;
using Tempest.Machines.Bx;
using UnityEngine;

public class StackTroika<TClipStack> : MonoBehaviour
    where TClipStack : ClipStack
{
    //Properties

    
    
    
    //
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void HandleLightColor_Top(int _triLightColor)
    { 
        this.GetComponent<Renderer>().material.color = Color.magenta;
    }
}
