using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFireScript : MonoBehaviour
{
    public float fireTimer;
    public float fireTime;

    public GameObject arrowPrefab;
    [SerializeField] private Transform spawnPos;

    void Update()
    {
        if (fireTime < fireTimer)
        {
            fireTime += Time.deltaTime;
        }
        else
        {
            fireTime = 0;

            Instantiate(arrowPrefab, spawnPos.position, Quaternion.identity, null);
        }
    }
}
