using UnityEngine;

public class block_prefab : MonoBehaviour
{
    private float rage = 100f;
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / rage;
    }
    void Update()
    {
        if (transform.position.y < -3f)
        {
            Destroy(gameObject);
        }
    }
    
}