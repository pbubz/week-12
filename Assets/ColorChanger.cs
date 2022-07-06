using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorChanger : MonoBehaviour
  

{
    public MeshRenderer myRenderer;
    public Color myColor;
    private Color startColor;
    
    public float changeDuration;
    private float currentDuration;

    public Color[] colorArray;

    private int colorIndex;

    // Start is called before the first frame update
    void Start()
    {
        startColor = myRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentDuration < changeDuration)
        {
            float changePercent = currentDuration / changeDuration;
            Color newColor= Color.Lerp(startColor, colorArray[colorIndex], changePercent);
            myRenderer.material.color = newColor;

            currentDuration += Time.deltaTime;
        }

        else
        {

            ++colorIndex;
            if (colorIndex > colorArray.Length-1)
            {
                colorIndex = 0;
            }
            startColor = myRenderer.material.color;
            currentDuration = 0f;
        }
        
        
    }
}
