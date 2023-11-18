using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(particle, transform.position, Quaternion.identity);
        if (collision.collider.tag == "enemy")
        {
            collision.collider.GetComponent<chase>().hurt(1);
        }
        Destroy(this.gameObject);
    }
}
