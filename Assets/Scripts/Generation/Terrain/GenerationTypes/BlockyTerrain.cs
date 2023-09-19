using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockyTerrain : GenerateTerrain
{
    public float BlockFactor = 0.1F;

    protected override float Y_Operator(float inY)
    {
        float returnY = inY;
        returnY *= BlockFactor;
        returnY = (int)(returnY);
        returnY /= BlockFactor;
        return returnY;
    }
}
