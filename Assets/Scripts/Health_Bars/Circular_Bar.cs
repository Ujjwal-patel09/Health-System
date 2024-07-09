using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circular_Bar : MonoBehaviour
{
   public float player_CurrentHealth = 100;
   public float player_MaxHealth = 100;

   Health_System player_health;

   // for circular bar//
   public Image ring_fill_bar;
   float lerpSpeed = 5f;
    
   void Start()
   {
      // construct player_health instance from health system//
      player_health = new Health_System(player_CurrentHealth,player_MaxHealth);
      //Debug.Log(player_health._CurrentHealth);
   }

   // circular fill bar //
   public void circular_fill_Amount()
   {
      lerpSpeed = 7f * Time.deltaTime;// increase ammount for harder the effect
      ring_fill_bar.fillAmount = Mathf.Lerp(ring_fill_bar.fillAmount,player_health._CurrentHealth / player_health._MaxHealth,lerpSpeed);// for smooth slide
      //ring_fill_bar.fillAmount = player_health._CurrentHealth / player_health._MaxHealth;// for absolute cut

      // for color //
      Color fill_color = Color.Lerp(Color.red,Color.green,(player_health._CurrentHealth / player_health._MaxHealth));
      ring_fill_bar.color = fill_color;
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
