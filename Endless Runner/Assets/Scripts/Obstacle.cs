﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public GameObject effect;
    private Shake shake;

    public GameObject explosionSound; 

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>(); 
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            Instantiate(explosionSound, transform.position, Quaternion.identity); 

            shake.CamShake();

            Instantiate(effect, transform.position, Quaternion.identity); 

            // player takes damage
            other.GetComponent<Player>().health -= damage;
            Debug.Log(other.GetComponent<Player>().health);

            Destroy(gameObject); 
        }
    }

}
