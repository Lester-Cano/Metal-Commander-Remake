using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMap : MonoBehaviour
{

    public int height;
    public int lenght;

    int[,] grid;


    public void Init(int lenght, int height)
    {
        grid = new int[lenght, height];

        this.lenght = lenght;
        this.height = height;
    }

    public void Set(int x, int y, int to)
    {
        if (CheckPosition(x, y) == false) 
        {
            Debug.LogWarning("Trying to access a cell outside of boundaries " + x.ToString() + ":" + y.ToString());
            return; 
        }
        grid[x, y] = to;
    }

    public int Get(int x, int y)
    {
        if (CheckPosition(x, y) == false) 
        {
            Debug.LogWarning("Trying to access a cell outside of boundaries " + x.ToString() + ":" + y.ToString());
            return -1; 
        }
        return grid[x, y];
    }

    public bool CheckPosition(int x, int y)
    {
        if (x < 0 || x >= lenght)
        {
            return false;
        }
        if (y < 0 || y >= height)
        {
            return false;
        }

        return true;
    }

}
