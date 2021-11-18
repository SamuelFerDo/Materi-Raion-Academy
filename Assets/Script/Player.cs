using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;

    public GameObject gameOver;

    [SerializeField] private float Yincrement;
    [SerializeField] private float movespeed;
    [SerializeField] private float maxHeight;
    [SerializeField] private float minHeight;

    public float playerHealth;
    public Text healthDisplay;

    private void Update()
    {
        healthDisplay.text = "HP: " + playerHealth.ToString();

        if(playerHealth <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, movespeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            //transform.position = targetPos;
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            //transform.position = targetPos;
        }
    }
}
