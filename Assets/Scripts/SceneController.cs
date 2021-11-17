using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{

    public GameObject enemyPrefab;
    private GameObject _enemy;
    public GameObject platform;


    private void Start()
    {
       
    }

    void Update()
    {
        if(_enemy == null)
        {
            _enemy = Instantiate(enemyPrefab , platform.transform) as GameObject;            
            float posX = Random.Range(-9, 9);
            float posZ = Random.Range(-9, 9);
            _enemy.transform.localPosition = new Vector3(posX, 1, posZ);
        }
    }
}
