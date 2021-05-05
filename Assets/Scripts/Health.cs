using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float healthPoints;
        bool isDead = false;

        public bool GetIsDead()
        {
            return isDead;
        }

        public void TakeDamage(float damage)
        {
            healthPoints = Mathf.Max(healthPoints - damage,0);
            if (healthPoints == 0) Die();

        }
        public void Die()
        {
            if (isDead) return;
            GetComponent<Animator>().SetBool("die",true);
            isDead = true;
            GetComponent<ActionScheduler>().CancelCurrentAction();
        }
    }
}
