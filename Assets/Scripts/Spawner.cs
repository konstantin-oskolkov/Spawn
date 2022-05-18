using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _wait = 2f;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform[] _spawnPoints;
   
   private void Start()
   {
      StartCoroutine(DelaySpawn());
   }

   private IEnumerator DelaySpawn()
   {
      while (!Input.GetKey(KeyCode.Space))
      {
         int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
         Instantiate(_enemy, _spawnPoints[spawnPointNumber]);

         yield return new WaitForSeconds(_wait);
      }
      yield break;
   }
}

