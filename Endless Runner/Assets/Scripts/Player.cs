using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class Player : MonoBehaviour
{

    private Vector2 targetPos;
    public float YIncrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 3;
 
    public Text healthDisplay;

        
    // Update is called once per frame
    private void Update()

    {

        healthDisplay.text = health.ToString(); 

        // if player has no more health
        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver"); 
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        // if player clicks up key 
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) 
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + YIncrement);
        }
        // if player clicks down key 
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)   
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - YIncrement);
        }
    }
}
