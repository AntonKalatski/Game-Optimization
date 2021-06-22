using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class EnemyTank : MonoBehaviour
{
    private Transform _player;
    private float _speed;

    public void Initialize(Transform player, float speed)
    {
        _speed = speed;
        _player = player;
        StartCoroutine(FollowPlayer());
    }
    private IEnumerator FollowPlayer()
    {
        while(true)
        {
            transform.LookAt(_player.transform.position);
            yield return new WaitForSeconds(Random.Range(1, 3));
        }
    }

    void Update()
    {
        transform.Translate(0, 0, _speed*Time.deltaTime);
    }
}
