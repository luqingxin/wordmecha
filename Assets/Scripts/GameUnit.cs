using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUnit : MonoBehaviour
{
    public GridMovable gridMovable;
    public int x, y;
    public GameManager gameManager;

    public GameUnit()
    {

    }

    public void updateTransform()
    {
        transform.position = new Vector3(x * gameManager.unitLength, y * gameManager.unitLength, 0);
    }

    public void move(int dx,int dy)
    {
        int nx, ny;
        nx = x + dx;
        ny = y + dy;
        if (nx > gameManager.row || nx < 1)
        {
            return;
        }
        if (ny > gameManager.column || ny < 1)
        {
            return;
        }
        if(gameManager.gridTypes[nx,ny] == GridType.Wall)
        {
            return;
        }
        if(gameManager.gameUnits[nx,ny] != null)
        {
            return;
        }
        gameManager.gameUnits[x, y] = null;
        x = nx;
        y = ny;
        gameManager.gameUnits[x, y] = this;
        Vector3 dPosition = new Vector3(dx * gameManager.unitLength, dy * gameManager.unitLength, 0);
        transform.position = transform.position + dPosition;
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(x * gameManager.unitLength, y * gameManager.unitLength, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
