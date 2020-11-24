using UnityEngine;
using UnityEngine.XR.ARFoundation;      //引用 Foundation API
using System.Collections.Generic;            //引用 系統.集合.一般 包含清單 List
/// <summary>
/// 點擊地面生成物件
/// </summary>
// RC 要求元件：在第一次套用腳本時執行
[RequireComponent(typeof(ARRaycastManager))]
public class ARManager : MonoBehaviour
{
    //生成物件
    [Header("點擊後生成的物件")]
    public GameObject obj;
    //AR管理器
    [Header("AR 管理器")]
    public ARRaycastManager arManager;
    //滑鼠座標
    private Vector2 pointMouse;
    //碰撞資訊
    private List<ARRaycastHit> hits;

  ///<summary>
  ///點擊
  ///</summary>
   private void tap()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            pointMouse = Input.mousePosition;
            print(pointMouse);
        }
        //判斷射線是否打到物件
        //生成物件
    }

    private void Update()
    {
        tap();
    }
}
