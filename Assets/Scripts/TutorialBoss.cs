using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBoss : MonoBehaviour
{
    void OnHit(float swordDamage)
    {
        Debug.Log("Hit for" + swordDamage);
    }
}
