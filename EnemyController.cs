using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour
{

    private NavMeshAgent _navMeshAgent;
    public Transform PlayerTransform;
    public float Health = 100;
    private float Damage = 10;
    private void Awake()
    {
        PlayerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.speed = 1.5f;
       
    }

    private void Update()
    {
 
        _navMeshAgent.SetDestination(PlayerTransform.position);
        

    }

    public void TakeDamage(GameObject enemy)
    {
        enemy.GetComponent<EnemyController>().Health -= 10;
        Debug.Log(enemy.name + " Health:" + enemy.GetComponent<EnemyController>().Health);

    }
}


