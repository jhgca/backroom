using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public bool specialsauce;
    public GameObject caine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!specialsauce)
            {
                GameManager.main.changecanes(10);
                Destroy(gameObject);

            }
            else
            {
                GameManager.main.changecanes(20);
                Destroy(gameObject);
            }
            Instantiate(caine, transform.position, Quaternion.identity);
        }
    }
}
