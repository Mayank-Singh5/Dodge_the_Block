using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private float slow = 5f;
    private Rigidbody2D rb;

    public float speed = 10f;
    void FixedUpdate()
    {
        rb = GetComponent<Rigidbody2D>();
        float pos = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        rb.MovePosition(new Vector2(Mathf.Clamp(rb.position.x + pos, -8.4f, 8.4f), rb.position.y));
    }
    void OnCollisionEnter2D()
    {
        StartCoroutine(Restart());
    }
    IEnumerator Restart()
    { 
        // before 1 sec
        Time.timeScale /= slow;
        Time.fixedDeltaTime /= slow;
        yield return new WaitForSeconds(0.2f);  
        // after 1 sec
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.fixedDeltaTime *= slow;
        Time.timeScale *= slow;
    }
}