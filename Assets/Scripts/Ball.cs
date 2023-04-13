using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpPower;

    public string currentColor;

    public SpriteRenderer sr;
    public Sprite[] ballSprites;

    public GameManager gm;
    void Start()
    {   
        //Baslangic rengi yesil
        RandomBall(4);
    }

    
    void Update()
    {
        
    }
    public void RandomBall(int index)
    {
        switch (index)
        {
            case 0:
                currentColor = "Red";
                sr.sprite = ballSprites[0];
                gameObject.tag = "Red";
                break;
            case 1:
                currentColor = "Yellow";
                sr.sprite = ballSprites[1];
                gameObject.tag = "Yellow";
                break;
                
            case 2:
                currentColor = "Blue";
                sr.sprite = ballSprites[2];
                gameObject.tag = "Blue";
                break;
            case 3:
                currentColor = "Purple";
                sr.sprite = ballSprites[3];
                gameObject.tag = "Purple";
                break;
            case 4:
                currentColor = "Green";
                sr.sprite = ballSprites[4];
                gameObject.tag = "Green";
                break;
            case 5:
                currentColor = "Orange";
                sr.sprite = ballSprites[5];
                gameObject.tag = "Orange";
                break;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Zýplamasý için
        rb.velocity = Vector3.up * jumpPower;

        if (collision.gameObject.tag != currentColor)
        {
            gm.RestartGame();
        }
        else
        {
            gm.score += 1;
            int randomNumber = Random.Range(0, 6);
            RandomBall(randomNumber);
        }

    }
}
