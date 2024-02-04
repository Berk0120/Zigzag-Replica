using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private Material groundMaterial;

    [SerializeField] private Color[] colors;

    private int ColorIndex = 0;

    [SerializeField] private float lerpValue;


    [SerializeField] private float time;

    private float currentTime;
   

   
    void Update()
    {
        SetColorChangeTime();
        SetGroundMaterialSmoothColorChange();
    }

    private void SetColorChangeTime()
    {
        if(currentTime <= 0)
        {
            CheckColorIndexValue();
           currentTime = 0;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndexValue()
    {
        ColorIndex++;

        if(ColorIndex >= colors.Length)
        {
            ColorIndex = 0;
        }
    }

    private void SetGroundMaterialSmoothColorChange()
    {
        groundMaterial.color = Color.Lerp(groundMaterial.color, colors[ColorIndex], lerpValue* Time.deltaTime); 
    }
    private void OnDestroy()
    {
        groundMaterial.color = colors[1];
    }
}
