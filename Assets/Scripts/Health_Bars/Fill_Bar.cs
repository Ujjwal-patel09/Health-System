using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fill_Bar : MonoBehaviour
{
   public float player_CurrentHealth = 100;
   public float player_MaxHealth = 100;

   Health_System player_health;

   // for fill Bar//
   public Image fill_Bar;
   float lerpSpeed = 5f;

   void Start() 
   {
     // construct player_health instance from health system//
      player_health = new Health_System(player_CurrentHealth,player_MaxHealth);
      //Debug.Log(player_health._CurrentHealth);
   }

    // fill bar //
   public void fill_Amount()
   {
      lerpSpeed = 10f * Time.deltaTime;// increase ammount for harder the effect
      fill_Bar.fillAmount = Mathf.Lerp(fill_Bar.fillAmount,player_health._CurrentHealth / player_health._MaxHealth,lerpSpeed);// for smooth slide
      //fill_Bar.fillAmount = player_health._CurrentHealth / player_health._MaxHealth;// for absolute cut

      // for color //
      Color fill_color = Color.Lerp(Color.red,Color.green,(player_health._CurrentHealth / player_health._MaxHealth));
      fill_Bar.color = fill_color;
   }

   public void TakeDamage()
   {
      player_health.Damage(20);
      //Debug.Log(player_health._CurrentHealth);
   }

   public void GainHealth()
   {
      player_health.Heal(20);
      //Debug.Log(player_health._CurrentHealth);
   }
}
