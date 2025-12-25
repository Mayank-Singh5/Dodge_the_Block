using UnityEditor;
using UnityEngine;

public class block_spawner : MonoBehaviour
{
    public GameObject prefab_obj;
    private float start_time = 2f;
    private float spawn_time = 1.5f;
    public Transform[] spawn_block;
    void Update()
    {   
        if (Time.timeSinceLevelLoad > start_time)
        {
            spawn();
            start_time += spawn_time;
        }
    }
    void spawn()
    {
        int temp = Random.Range(0, spawn_block.Length);
        for (int i = 0; i < spawn_block.Length; i++)
        {
            if (i != temp)
            {
                Instantiate(prefab_obj, spawn_block[i].position, Quaternion.identity);
            }
        }
    }
}