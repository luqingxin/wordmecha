using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int row, column;
    public GameUnit[,] gameUnits = new GameUnit[30,30];
    public float unitLength = 1;
    public GridType[,] gridTypes = new GridType[30,30];
    public MapEdit mapEdit;
    public Map map;
    public GameObject enemy;
    public MainCharacter mainCharacter;

    // Start is called before the first frame update
    void Start()
    {
        mapEdit.initMap();
        Debug.Log(mapEdit.mapDesign[5, 5]);
        for (int i = 1; i <= row; i++)
            for (int j = 1; j <= column; j++)
            {
                if(mapEdit.mapDesign[i,j] == 0)
                {
                    Debug.Log(0);
                    gridTypes[i, j] = GridType.Groud;
                }
                else if(mapEdit.mapDesign[i, j] == 1)
                {
                    Debug.Log(1);
                    gridTypes[i, j] = GridType.Wall;
                }
            }
        for (int i = 1 ; i <= row ; i ++)
            for (int j = 1; j <= column; j++)
            {
                gameUnits[i, j] = null;
            }
        map.updateMap();
        initEnemy();
    }

    public void AttackButtonClick()
    {
        int mx = mainCharacter.x;
        int my = mainCharacter.y;
        if(gameUnits[mx-1,my] != null)
        {
            Destroy(gameUnits[mx - 1, my].gameObject);
        }
        if (gameUnits[mx +1, my] != null)
        {
            Destroy(gameUnits[mx - 1, my].gameObject);
        }
        if (gameUnits[mx , my-1] != null)
        {
            Destroy(gameUnits[mx - 1, my].gameObject);
        }
        if (gameUnits[mx , my+1] != null)
        {
            Destroy(gameUnits[mx - 1, my].gameObject);
        }
    }

    public void initEnemy()
    {
        gameUnits[5,5] = Instantiate(enemy, new Vector2(0, 0), Quaternion.identity).GetComponent<Enemy>();
        gameUnits[5, 5].x = 5;
        gameUnits[5, 5].y = 5;
        gameUnits[5, 5].gameManager = this;
        gameUnits[5, 5].updateTransform();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
