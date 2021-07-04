using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelsDetector : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite sprite;

    public Color color;
    public Texture2D textura; 

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(sprite.rect);
        color = textura.GetPixel(0, 0);
        Debug.Log(color); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
