using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    private float timer = 0.0f;
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 1.0f)
        {
            Color newColor = new Color(255, Random.value, Random.value, 1.0f);
            meshRenderer.material.color = newColor;
            timer = 0;
        }

        
    }
}
