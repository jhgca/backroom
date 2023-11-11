using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class help : MonoBehaviour
{
    public Sprite openSprite;
    public Sprite closeSprite;
    SpriteRenderer sr;
    Collider2D col;
    bool open = true;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Vector2.Distance(transform.position, GameManager.main.player.transform.position) < 2)
            {
                if (open)
                {
                    Close();
                }
                else
                {
                    Open();
                }
            }
        }
    }
    void Open()
    {
        sr.sprite = openSprite;
        col.enabled = false;
        open = true;
    }
    void Close()
    {
        sr.sprite = closeSprite;
        col.enabled = true;
        open = false;
    }
}
