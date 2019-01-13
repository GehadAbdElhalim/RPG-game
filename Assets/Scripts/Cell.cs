using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Terrain
{
    Grass, Dirt, Water
};

public enum Effect
{
    Fire, Thunder, NoEffect
};

public class Cell
{
    Terrain terrain;
    Effect effect;

    public Cell(Terrain t, Effect e)
    {
        this.terrain = t;
        this.effect = e;
    }

    public void ApplyEffect()
    {

    }

    public void getEffect()
    {

    }
}
