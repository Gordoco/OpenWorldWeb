using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GenerateMazeChunks : GenerateChunks
{
    protected override void resizeChunks(GenerateTerrain terrainLogic)
    {
        if ((MazeGenerator)terrainLogic != null) chunkSize = ((MazeGenerator)terrainLogic).getSourceTextWidth();
        base.resizeChunks(terrainLogic);
    }
}
