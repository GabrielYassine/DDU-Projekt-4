using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
   KillCounter KillCounterScript;
   public float health = 10f;

   private void Start()
    {
        KillCounterScript = GameObject.Find("KCO").GetComponent<KillCounter>();
    }

   public void TakeDamage (float amount)
   {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
   }

   void Die()
   {
        Destroy(gameObject);
        KillCounterScript.AddKill();
   }
}
