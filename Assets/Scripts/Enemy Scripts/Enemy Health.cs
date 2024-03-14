using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100.0f;
    private Animator mAnimator;
    BasicEnemyAI ai;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (health <= 0)
        {
            GetComponent<Animator>().enabled = false;
            GetComponent<BasicEnemyAI>().enabled = false;
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fists")
        {
            Debug.Log("HIT!");
            health -= 10;
        }
    }
    
        
    
}
