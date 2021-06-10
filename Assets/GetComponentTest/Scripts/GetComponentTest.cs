using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentTest : MonoBehaviour
{
    private Transform transform;
    private void Start()
    {
        GetComponentT();
        GetComponentString();
        GetComponentTypeOf();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponentT();
            GetComponentString();
            GetComponentTypeOf();
        }
    }

    private void GetComponentT()
    {
        for (int i = 0; i < 5000; i++)
        {
            var transform = GetComponent<Transform>();
        }
    } 
    private void GetComponentString()
    {
        for (int i = 0; i < 5000; i++)
        {
            var  transform = (Transform) GetComponent("Transform");
        }
    }
    private void GetComponentTypeOf()
    {
        for (int i = 0; i < 5000; i++)
        {
            var transform = (Transform) GetComponent(typeof(Transform));
        }
    }
}
