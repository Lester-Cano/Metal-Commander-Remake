using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridControl : MonoBehaviour
{
    [SerializeField] Tilemap targetTilemap;
    [SerializeField] GridManager gridManager;

    private void Update()
    {
        MouseInput();
    }

    private void MouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int clickPosition = targetTilemap.WorldToCell(worldPoint);
            gridManager.Set(clickPosition.x, clickPosition.y, 1);
        }
    }


}
