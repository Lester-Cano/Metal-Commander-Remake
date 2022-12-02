using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(Tilemap))]
[RequireComponent(typeof(GridMap))]

public class GridManager : MonoBehaviour
{

    Tilemap tilemap;
    GridMap grid;
    [SerializeField] TileBase tileBase;
    [SerializeField] TileBase tileBase2;

    [SerializeField] TileSet tileSet;


    void Start()
    {

        tilemap = GetComponent<Tilemap>();
        grid = GetComponent<GridMap>();

        grid.Init(10, 8);
        Set(1, 1, 2);
        Set(1, 2, 2);
        Set(2, 1, 2);
        UpdateTilemap();
    }

    void UpdateTilemap()
    {
        for (int x =0; x < grid.lenght; x++)
        {
            for (int y=0; y < grid.height; y++)
            {
                UpdateTile(x, y);
            }
        }
    }

    private void UpdateTile(int x, int y)
    {

        int tileId = grid.Get(x, y);
        if (tileId == -1)
        {
            return;
        }

        tilemap.SetTile(new Vector3Int(x, y, 0), tileSet.tiles[tileId]);
       
    }

    public void Set(int x, int y, int to)
    {
        grid.Set(x, y, to);
        UpdateTile(x,y);
    }
   
}
