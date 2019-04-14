using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode, ImageEffectAllowedInSceneView]
public class BindPostProcessing : MonoBehaviour
{
    [Range(1, 16)]
    public int iterations = 1;
    public Material postProcessingMaterial;

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        int width = source.width / 2;
		int height = source.height / 2;
		RenderTextureFormat format = source.format;

        RenderTexture currentDestination =
            RenderTexture.GetTemporary(width, height, 0, format);

        Graphics.Blit(source, currentDestination);
        RenderTexture currentSource = currentDestination;
        Graphics.Blit(currentSource, destination);
        RenderTexture.ReleaseTemporary(currentSource);
    }
}
