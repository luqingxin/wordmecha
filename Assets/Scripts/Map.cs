using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.Scripting;

public class Map : MonoBehaviour
{
    public int column, row;
    public GameManager gameManager;
    public GameObject wall, pre;

    public void updateMap()
    {
        row = gameManager.row;
        column = gameManager.column;
        for (int i = 1; i <= row; i++)
        {
            for (int j = 1; j <= column; j++)
            {
                if (gameManager.gridTypes[i, j] == GridType.Wall)
                {
                    Instantiate(wall, new Vector2(i * gameManager.unitLength, j * gameManager.unitLength), Quaternion.identity);
                }
                else if (gameManager.gridTypes[i, j] == GridType.Groud)
                {
                    Instantiate(pre, new Vector2(i * gameManager.unitLength, j * gameManager.unitLength), Quaternion.identity);
                }
            }
        }
    }

// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
