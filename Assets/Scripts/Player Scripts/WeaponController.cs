using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    public GameObject Fist;
    public bool CanAttack = true;
    public float AttackCooldown = 1.0f;
    public bool isAttacking = false;
    public GameObject BloodParticle;

    private void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(CanAttack)
            {
                
                punchAttack();
            }
        }


    }
    public void punchAttack()
    {
        isAttacking = true;
        CanAttack = false;
        StartCoroutine(ResetAttackCoolDown());

    }
    


    IEnumerator ResetAttackCoolDown()
    {
        StartCoroutine(ResetAttackBool());
        yield return new WaitForSeconds(AttackCooldown);
        CanAttack = true;
        
    }

    IEnumerator ResetAttackBool()
    {
        yield return new WaitForSeconds(1.0f);
        isAttacking = false;
    }
  
}
