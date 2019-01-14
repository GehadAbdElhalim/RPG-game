using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    Cell[] map;
    public int height = 5;
    public int width = 5;
    public GameObject cellType;

    void Start()
    {
        map = new Cell[height * width];
        Generate();
    }

    void Generate()
    {
        int k = 0;

        for(int i = -(height/2); i<=(height/2); i++)
        {
            for(int j = -(width/2); j<=(width/2); j++)
            {
                map[k] = new Cell();
                GameObject a = Instantiate(cellType, new Vector2(i, j),Quaternion.identity);
                a.transform.parent = this.transform;
                k++;
            }
        }
    }

}
