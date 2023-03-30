using System;
using UnityEngine;
using Tempest;

public class ButtonThingEvent : MonoBehaviour
{
    //Fields
    public TriLight LightTop;
    public TriLight LightMiddle;
    public TriLight LightBottom;

    private Material TopMat;
    private Material MiddleMat;
    private Material BottomMat;
    
    //Unity Message
    public void Awake()
    {
        TopMat = LightTop.GetComponent<Renderer>().material;
        MiddleMat = LightMiddle.GetComponent<Renderer>().material;
        BottomMat = LightBottom.GetComponent<Renderer>().material;
    }


    //Mono Methods
    public void HandleLightColor_Top(int _triLightColor)
    {
        TopMat.color = Color.red;
    }
    public void HandleLightColor_Middle(int _triLightColor)
    {
        MiddleMat.color = Color.yellow;
    }
    public void HandleLightColor_Bottom(int _triLightColor)
    {
        BottomMat.color = Color.green;
    }
}