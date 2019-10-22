using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{

    [Header("移動速度"), Range(1, 100)] public float MoveSpeed = 15f;
    [Header("選轉速度"), Range(1, 100)] public float RotateSpeed = 30f;
    [Header("汽車檔次"), Range(1, 5)] public int CarLevel = 1;
    [Header("汽車品牌")] public string CarBrand = "BMW";
    [Header("是否煞車"), Tooltip("是否煞車")] public bool CarBrake = false;
    [Header("汽車顏色"),] public Color CarColor = Color.white;
    [Header("汽車元件")] public Transform Car;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 車子前進
    /// </summary>
    public void CarMove()
    {
        Car.Translate(0f,0f, MoveSpeed*Time.deltaTime);
    }
    /// <summary>
    /// 車子後退
    /// </summary>
    public void CarBack()
    {
        Car.Translate(0f, 0f, -MoveSpeed*Time.deltaTime);

    }
    /// <summary>
    /// 車子左轉
    /// </summary>
    public void CarLeft()
    {
        Car.Rotate(0f, -RotateSpeed * Time.deltaTime,0f);
    }   
    /// <summary>
         /// 車子前進
         /// </summary>
    public void CarRight()
    {
        Car.Rotate(0f, RotateSpeed * Time.deltaTime, 0f);
    }





}
