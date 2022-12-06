using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Rigidbody2D ballRb;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Init(Vector2 dir)
    {
        ballRb.velocity = dir* speed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        //col.transform.GetComponent
    }
}
