using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class World
{
    // Height of the Map 
    // corresponds to x Direction
    public int Height
    {
        get;
        protected set;
    }

    // Width of the Map
    // corresponds to z Direction
    public int Width
    {
        get;
        protected set;
    }

    // Array of all the Tiles in the World
    private Tile[,] _tiles;

    // empty Constructor for serialization
    public World()
    {

    }

    public World(int width, int height)
    {
        // TODO: Construct World
    }

    // returns the tile at the specified location
    public Tile GetTileAt(int x, int z)
    {
        return _tiles[x, z];
    }

    // retuns the tile at the specified location (floored to int)
    public Tile GetTileAt(float x, float z)
    {
        return _tiles[Mathf.FloorToInt(x), Mathf.FloorToInt(z)];
    }

}
