using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetect : MonoBehaviour
{
    public WeaponController wp ;
    public GameObject BloodParticle;
    public float ParticleMover = 4.24f;
    public float DeleteBlood = 1.0f;



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && wp.isAttacking)
        {
            Debug.Log(other.name);
            other.GetComponent<Animator>().SetTrigger("Hit");
            Instantiate(BloodParticle, new Vector3(other.transform.position.x, transform.position.y + ParticleMover, other.transform.position.z), other.transform.rotation);
            
            
            
        }
       

    }


  

}
