using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Durability : MonoBehaviour
{
    public ProgressBar Pb;

    private int durability = 100;

    void Start()
    {
       Pb.BarValue = durability;  
    }


    private void OnCollisionStay(Collision col) {
        if (!col.gameObject.CompareTag("Target"))
        {
            durability -= 1;
            Pb.BarValue = durability; 

            if (durability == 0)
            {
                Target.lose = true;
            }
        }
    }
} 