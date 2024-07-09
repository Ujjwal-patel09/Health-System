using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Number_Bar : MonoBehaviour
{
   public float player_CurrentHealth = 100;
   public float player_MaxHealth = 100;

   Health_System player_health;

   public TextMeshProUGUI health_text;

   void Start() 
   {
      // construct player_health instance from health system//
      player_health = new Health_System(player_CurrentHealth,player_MaxHealth);
      //Debug.Log(player_health._CurrentHealth);
   }

   void Update() 
   {
     health_text.text = player_health._CurrentHealth.ToString(); 
   }

   public void TakeDamage()
   {
      player_health.Damage(10);
      //Debug.Log(player_health._CurrentHealth);
   }

   public void GainHealth()
   {
      player_health.Heal(10);
      //Debug.Log(player_health._CurrentHealth);
   }
}
