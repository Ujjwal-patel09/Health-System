using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_manager : MonoBehaviour
{
   public float player_CurrentHealth = 100;
   public float player_MaxHealth = 100;

   Health_System player_health;

   // for slider health bar //
   public Slider slider;
   public Gradient gradient;//for color
   public Image fill;

   // for fill & Circular health bar //
   public Image fill_Bar;
   public Image ring_fill_bar;
   float lerpSpeed = 5f;

   private void Start() 
   {
      // construct player_health instance from health system//
      player_health = new Health_System(player_CurrentHealth,player_MaxHealth);
      Debug.Log(player_health._CurrentHealth);

      // slider bar
      slider.maxValue = player_health._MaxHealth; 
      slider.value = player_health._CurrentHealth;
      fill.color = gradient.Evaluate(1f);

   }

   private void Update() 
   {
     //fill  bar//  
     fill_Health_Amount();

     //Circular fill bar//
     circular_fill_Health_Amount();
   }
   
   // fill bar //
   void fill_Health_Amount()
   {
      lerpSpeed = 7f * Time.deltaTime;// increase ammount for harder the effect
      fill_Bar.fillAmount = Mathf.Lerp(fill_Bar.fillAmount,player_health._CurrentHealth / player_health._MaxHealth,lerpSpeed);// for smooth slide
      //fill_Bar.fillAmount = player_health._CurrentHealth / player_health._MaxHealth;// for absolute cut

      // for color //
      Color fill_color = Color.Lerp(Color.red,Color.green,(player_health._CurrentHealth / player_health._MaxHealth));
      fill_Bar.color = fill_color;
   }

   // circular fill bar //
    void circular_fill_Health_Amount()
   {
      lerpSpeed = 7f * Time.deltaTime;// increase ammount for harder the effect
      ring_fill_bar.fillAmount = Mathf.Lerp(fill_Bar.fillAmount,player_health._CurrentHealth / player_health._MaxHealth,lerpSpeed);// for smooth slide
      //ring_fill_bar.fillAmount = player_health._CurrentHealth / player_health._MaxHealth;// for absolute cut

      // for color //
      Color fill_color = Color.Lerp(Color.red,Color.green,(player_health._CurrentHealth / player_health._MaxHealth));
      ring_fill_bar.color = fill_color;
   }

   // use in button events //
   public void TakeDamage()
   {
      player_health.Damage(20);
      Debug.Log(player_health._CurrentHealth);

      //slider bar
      slider.value = player_health._CurrentHealth;
      fill.color = gradient.Evaluate(slider.normalizedValue);
      
    }

   public void GainHeal()
   {
      player_health.Heal(20);
      Debug.Log(player_health._CurrentHealth);

      //slider bar
      slider.value = player_health._CurrentHealth;
      fill.color = gradient.Evaluate(slider.normalizedValue);
   }
}
