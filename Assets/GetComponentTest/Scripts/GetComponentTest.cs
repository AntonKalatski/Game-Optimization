using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentTest : MonoBehaviour
{
    private void Start()
    {
        GetSearchable1();
        GetSearchable2();
        GetSearchable3();
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetSearchable1();
            GetSearchable2();
            GetSearchable3();

        }
    }

    private void GetSearchable1()
    {
        for (int i = 0; i < 5000; i++)
        {
            var searchable = (ISearchable)GetComponent("ISearchable");
        }
    }
    private void GetSearchable2()
    {
        for (int i = 0; i < 5000; i++)
        {
            var searchable = GetComponent<ISearchable>();
        }
    }
    private void GetSearchable3()
    {
        for (int i = 0; i < 5000; i++)
        {
            var searchable = (ISearchable)GetComponent(typeof (ISearchable));
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
            var transform = (Transform)GetComponent("Transform");
        }
    }
    private void GetComponentTypeOf()
    {
        for (int i = 0; i < 5000; i++)
        {
            var transform = (Transform)GetComponent(typeof(Transform));
        }
    }
}
