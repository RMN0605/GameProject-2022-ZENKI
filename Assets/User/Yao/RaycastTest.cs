using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{

    void Update()
    {
        //物体の座標を特定

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 10.0f))
        {
            Debug.Log(hit.collider.gameObject.transform.position);
        }
    }
}

//*
// 物体が複数の場合

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
 
//public class Test : MonoBehaviour
//{

//    void Update()
//    {
//        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//        foreach (RaycastHit hit in Physics.RaycastAll(ray))
//        {
//            Debug.Log(hit.collider.gameObject.transform.position);
//        }

//    }
//}

//*

//*
//「ray」の可視化

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
 
//public class Test : MonoBehaviour
//{

//    void Update()
//    {
//        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//        RaycastHit hit;
//        if (Physics.Raycast(ray, out hit, 10.0f))
//        {
//            Debug.Log(hit.collider.gameObject.transform.position);
//        }
//        Debug.DrawRay(ray.origin, ray.direction * 10, Color.red, 5);
//    }
//}