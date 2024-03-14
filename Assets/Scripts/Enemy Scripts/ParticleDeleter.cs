using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ParticleDeleter : MonoBehaviour
{
    
    
    public void Start()
    {
        Destroy(this.gameObject, 3);
    }
  
    
}
