using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Camera rCamera;
    [SerializeField]
    private Material rMaterial;

    [SerializeField]
    private Camera gCamera;
    [SerializeField]
    private Material gMaterial;

    [SerializeField]
    private Camera bCamera;
    [SerializeField]
    private Material bMaterial;

    [SerializeField]
    private Camera pCamera;
    [SerializeField]
    private Material pMaterial;


    // Start is called before the first frame update
    void Start()
    {
        // RedRoom
        if(rCamera.targetTexture != null)
        {
            rCamera.targetTexture.Release();
        }

        // Syvyys = 24
        rCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        rMaterial.mainTexture = rCamera.targetTexture;


        // GreenRoom
        if (gCamera.targetTexture != null)
        {
            gCamera.targetTexture.Release();
        }

        gCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        gMaterial.mainTexture = gCamera.targetTexture;


        // BlueRoom
        if (bCamera.targetTexture != null)
        {
            bCamera.targetTexture.Release();
        }

        bCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        bMaterial.mainTexture = bCamera.targetTexture;


        // BlackRoom
        if (pCamera.targetTexture != null)
        {
            pCamera.targetTexture.Release();
        }

        pCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        pMaterial.mainTexture = pCamera.targetTexture;
    }
}
