using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEdit : MonoBehaviour
{
    public GameManager gameManager;
    public int[,] mapDesign = new int[30,30];
    public int row, column;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void initMap()
    {
        row = gameManager.row;
        column = gameManager.column;
        for (int i = 1; i <= row; i++)
            for (int j = 1; j <= column; j++)
            {
                if (i == 1 || j == 1 || i == row || j == column)
                {
                    mapDesign[i, j] = 1;
                }
                else
                {
                    mapDesign[i, j] = 0;
                }
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
