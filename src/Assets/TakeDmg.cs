using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDmg : MonoBehaviour
{
    private int health = 99;
    public GameObject enemyPrefab;
    public GameObject gameManagerObject;

    private Vector3 initialPos;

    void Start()
    {
        initialPos = transform.position;
    }

    void Update()
    {
        if(health <= 0)
        {
            gameObject.SetActive(false);
            gameObject.transform.position = initialPos;
            gameObject.SetActive(true);
            health = 99;
            gameManagerObject.GetComponent<GameManager>().currentScore++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            health -= 33;
        }
    }
}
