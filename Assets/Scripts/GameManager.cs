using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class GameMap
{
    public Transform[] coordinate = new Transform[4];
   
}
public class SaveEmpty
{
    public int[] emptyNum = new int[2];
}
public class GameManager : MonoBehaviour
{
    public GameObject tilePrefab;
    public GameMap[] gameMap = new GameMap[4];
    public int[,] map = new int[4, 4] {
                                        {0,0,0,0},
                                        {0,0,0,0},
                                        {0,0,0,0},
                                        {0,0,0,0}
                                      };
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void StartGame()
    {
        RandomPosition();
        RandomPosition();
        UpdatTiles();
    }
    private void UpdatTiles()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (map[i, j] != 0)
                {
                    Instantiate(tilePrefab, gameMap[i].coordinate[j].position, Quaternion.identity);
                }
            }
        }
    }
    private void RandomPosition()
    {
        List<SaveEmpty>saveEmpty = new List<SaveEmpty>();
        int rand;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (map[i, j] != 0)
                {
                    SaveEmpty save = new SaveEmpty();
                    save.emptyNum[0] = i;
                    save.emptyNum[1] = j;
                    saveEmpty.Add(save);
                }
            }
        }
        rand = UnityEngine.Random.Range(0, saveEmpty.Count);
        print("2");
        foreach (SaveEmpty s in saveEmpty)
        {
            print("1");
        }
        /*map[saveEmpty[rand].emptyNum[0], saveEmpty[rand].emptyNum[1]] = 1;*/
    }
}
