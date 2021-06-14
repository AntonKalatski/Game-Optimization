using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAIBenchmark : MonoBehaviour
{
    [SerializeField] private EnemyTank[] tanks;
    [SerializeField] private EnemyTank tankPrefab;
    [SerializeField] private GameObject playerTank;
    [SerializeField] private int numberOfTanks;
    [SerializeField] private float speed;

    void Start()
    {
        tanks = new EnemyTank[numberOfTanks];
        EnemyTank tank;
        for (int i = 0; i < numberOfTanks; i++)
        {
            tank = Instantiate(tankPrefab);
            tank.transform.position = new Vector3(Random.Range(-50, 50), 0, Random.Range(-50, 50));
            tank.Initialize(playerTank.transform,speed);
            tanks[i] = tank;
        }
    }
}
