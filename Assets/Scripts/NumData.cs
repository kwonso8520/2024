using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NumData : MonoBehaviour
{
    [SerializeField]
    private Text numText;
    Camera camera;
    public int tileNum = 2;
  /*  private void Start()
    {
        camera = FindObjectOfType<Camera>();
    }
    private void Update()
    {
        numText.text = tileNum.ToString();
        numText.transform.position = camera.WorldToScreenPoint(gameObject.transform.position);
    }*/
}