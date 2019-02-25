using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveFlagTexture : MonoBehaviour
{
    public RenderTexture rt;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SaveTexture();
        }
    }
    
    // Use this for initialization
    public void SaveTexture()
    {
        byte[] bytes = toTexture2D(rt).EncodeToPNG();
        System.IO.File.WriteAllBytes("C:/Users/Chandler Holloway/Documents/GitHub/Unity-FlagCreator/Assets/Flag-Emblem Creator/Saved Flags/Flag_1.png", bytes);
    }
    Texture2D toTexture2D(RenderTexture rTex)
    {
        Texture2D tex = new Texture2D(rTex.width, rTex.height, TextureFormat.RGB24, false);
        RenderTexture.active = rTex;
        tex.ReadPixels(new Rect(0, 0, rTex.width, rTex.height), 0, 0);
        tex.Apply();
        return tex;
    }
}