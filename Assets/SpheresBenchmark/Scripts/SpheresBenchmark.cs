using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpheresBenchmark : MonoBehaviour
{
    public int numberOfSpheres = 100;
    [SerializeField] private List<GameObject> spheres;

    // Start is called before the first frame update
    void Start()
    {
        var material = new Material(Shader.Find("Specular"));
        material.color = Color.red;
        spheres = new List<GameObject>();
        for (int i = 0; i < numberOfSpheres; i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            spheres.Add(sphere);
            Renderer rend = (Renderer)sphere.GetComponent("Renderer");
            rend.material = material;
            sphere.transform.position = Random.insideUnitSphere * 20;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var t in spheres)
            {
                t.transform.Translate(0, 0, 0.01f);
            }
        }
    }
}
