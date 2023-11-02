using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GenerateMazeChunks : GenerateChunks
{

    [SerializeField] private bool hasFloor = true;
    [SerializeField] private Texture2D sourceTex;

    protected override void resizeChunks(GenerateTerrain terrainLogic)
    {
        if ((MazeGenerator)terrainLogic != null)
        {
            if (sourceTex) ((MazeGenerator)terrainLogic).setSourceTex(sourceTex);
            chunkSize = ((MazeGenerator)terrainLogic).getSourceTextWidth();
            ((MazeGenerator)terrainLogic).hasFloor = hasFloor;
            if (meshMat)
            {
                int scale = 100 * (((MazeGenerator)terrainLogic).getSourceTextWidth() / 20);
                meshMat.mainTextureScale = new Vector2(scale, scale);
            }
        }
        base.resizeChunks(terrainLogic);
    }
}
