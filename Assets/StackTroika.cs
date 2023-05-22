using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTroika : MonoBehaviour
{
    // Start is called before the first frame update
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
