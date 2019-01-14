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

    public Cell()
    {
        this.terrain = Terrain.Grass;
        this.effect = Effect.NoEffect;
    }

    public Cell(Terrain t)
    {
        this.effect = Effect.NoEffect;
        this.terrain = t;
    }

    public Cell(Terrain t, Effect e)
    {
        this.terrain = t;
        this.effect = e;
    }

    public void ApplyEffect(Effect e)
    {
        this.effect = e;
    }

    public Effect getEffect()
    {
        return this.effect;
    }
}
