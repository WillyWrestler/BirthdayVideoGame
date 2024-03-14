using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPunching : MonoBehaviour
{
    public float AttackCooldown = 1.0f;
    bool punchTrue;
    private Animator mAnimator;
    Collider f_Collider;
    void Start()
    {
        f_Collider = GetComponent<Collider>();
        f_Collider.enabled = false;
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mAnimator != null)
        {

        
        if (Input.GetButtonDown("Fire1"))
        {
                f_Collider.enabled = true;
                mAnimator.SetTrigger("punchTrue");
                StartCoroutine(ResetAttackCoolDown());
            }
            IEnumerator ResetAttackCoolDown()
            {
                
                yield return new WaitForSeconds(AttackCooldown);
                f_Collider.enabled = false;
            }
           


            if (Input.GetButtonUp("Fire1"))
        {
                
                mAnimator.SetTrigger("Idle");
            }
        }
    }
}
