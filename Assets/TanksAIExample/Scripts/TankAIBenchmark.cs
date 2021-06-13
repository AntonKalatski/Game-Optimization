using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAIBenchmark : MonoBehaviour
{
    [SerializeField] private Transform[] tanks;
    [SerializeField] private GameObject tankPrefab;
    [SerializeField] private GameObject playerTank;
    [SerializeField] private int numberOfTanks;
    [SerializeField] private float speed;

    void Start()
    {
        speed = Random.Range(1f, 8f);
        tanks = new Transform[numberOfTanks];
        GameObject tank;
        for (int i = 0; i < numberOfTanks; i++)
        {
            tank = Instantiate(tankPrefab);
            tank.transform.position = new Vector3(Random.Range(-50, 50), 0, Random.Range(-50, 50));
            tanks[i] = tank.transform;
        }
    }

    void Update()
    {
        foreach (Transform t in tanks)
        {
            if (playerTank != null)
            {
                t.LookAt(playerTank.transform.position);
                t.Translate(0, 0, speed * Time.deltaTime);
            }
        }
    }
}
