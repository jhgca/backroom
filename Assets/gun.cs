using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform firespot;
    public GameObject boulet;
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouspos = Input.mousePosition;
        Vector3 screenpos = Camera.main.ScreenToWorldPoint(mouspos);
        screenpos = new Vector3 (screenpos.x, screenpos.y, 0);
        transform.right = screenpos - transform.position;
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (GameManager.main.canes <= 0)
            {
                return;
            }
            GameObject instance = Instantiate(boulet, firespot.position, firespot.rotation);
            instance.GetComponent<Rigidbody2D>().AddForce (firespot.right * velocity, ForceMode2D.Impulse);
            GameManager.main.changecanes(-1);

        }
    }
}
