using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : GameUnit
{




    // Start is called before the first frame update
    void Start()
    {
        gameManager.gameUnits[x, y] = this;
        gameManager.mainCharacter = this;
        updateTransform();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            move(0, 1);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            move(0, -1);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            move(-1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            move(1, 0);
        }
    }
}
