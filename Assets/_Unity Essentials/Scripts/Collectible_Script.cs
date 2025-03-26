using UnityEngine;

public class Collectible_Script : MonoBehaviour
{
    public float rotation_speed;
    public GameObject onCollectEffect;

     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotation_speed, 0);    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {   // Destroy the collectible
            Destroy(gameObject);

            //Instantiate Particle
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
        }
    }
