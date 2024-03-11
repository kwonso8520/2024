using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TileController : MonoBehaviour
{
    public float distance = 2;
    private NumData numData;
    public float x;
    GameManager gameManager;
    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    void Start()
    {
        numData = GetComponent<NumData>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
           
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {

        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {

        }

    }
}
