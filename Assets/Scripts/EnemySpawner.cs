using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    public int SpawnDelay;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > i)
        {
            i += SpawnDelay;
            Instantiate(Enemy, gameObject.transform);
        }
    }
}
