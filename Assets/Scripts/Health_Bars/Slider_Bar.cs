using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_Bar : MonoBehaviour
{

   public float player_CurrentHealth = 100;
   public float player_MaxHealth = 100;

   Health_System player_health;

   // for slider health bar //
   public Slider slider;
   public Gradient gradient;//for color
   public Image fill;

    void Start()
    {
      // construct player_health instance from health system//
      player_health = new Health_System(player_CurrentHealth,player_MaxHealth);
      //Debug.Log(player_health._CurrentHealth);

      // slider bar
      slider.maxValue = player_health._MaxHealth; 
      slider.value = player_health._CurrentHealth;
      fill.color = gradient.Evaluate(1f);
        
    }

   public void TakeDamage()
   {
      player_health.Damage(20);
      //Debug.Log(player_health._CurrentHealth);

      //slider bar
      slider.value = player_health._CurrentHealth;
      fill.color = gradient.Evaluate(slider.normalizedValue);
   }

   public void GainHealth()
   {
      player_health.Heal(20);
      //Debug.Log(player_health._CurrentHealth);

      //slider bar
      slider.value = player_health._CurrentHealth;
      fill.color = gradient.Evaluate(slider.normalizedValue);
   }
}
