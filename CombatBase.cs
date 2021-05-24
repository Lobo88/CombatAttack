using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatBase : MonoBehaviour
{
   
   private List<GameObject> EnemiesList = new List<GameObject>();
   
    public void TryAttack()
    {
        if (EnemiesList.Count > 0)
        EnemiesList[0].gameObject.GetComponent<EnemyController>().TakeDamage(EnemiesList[0].gameObject);
        
    }
        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log(other.name + " add");
            EnemiesList.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log(other.name + " out");
            EnemiesList.Remove(other.gameObject);
          
        }
       
    }

    }
