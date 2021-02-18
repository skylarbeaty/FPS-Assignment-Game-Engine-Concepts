using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyDestroy : MonoBehaviour
{
    void Start()
    {
        if (!GameFlowManager.hardMode){
            FindObjectOfType<EnemyManager>().UnregisterEnemy(GetComponent<EnemyController>());//remove from list to kill for level
            Destroy(gameObject);
        }
    }
}
