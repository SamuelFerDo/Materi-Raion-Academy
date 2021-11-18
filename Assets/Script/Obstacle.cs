using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Player>().playerHealth -= 1;
            Destroy(this.gameObject);
          /*  if(collision.GetComponent<Player>().playerHealth == 0)
            {
                Destroy(collision);
            }*/
        }
    }
}
