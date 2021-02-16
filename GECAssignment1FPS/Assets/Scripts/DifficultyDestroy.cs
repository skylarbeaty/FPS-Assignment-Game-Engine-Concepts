using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyDestroy : MonoBehaviour
{
    void Start()
    {
        if (!GameFlowManager.hardMode)
            Destroy(gameObject);
    }
}
