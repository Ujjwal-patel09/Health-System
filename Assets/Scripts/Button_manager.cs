using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_manager : MonoBehaviour
{
   public Slider_Bar slider_Bar;
   public Fill_Bar fill_Bar;
   public Circular_Bar circular_Bar;
   public Block_Bar block_Bar;
   public Tail_Bar tail_Bar;
   public Heart_Bar heart_Bar;
   public Number_Bar number_Bar;

   private void Update() 
   {
      fill_Bar.fill_Amount();
      circular_Bar.circular_fill_Amount();
      block_Bar.Block_Filler();
      heart_Bar.heart_Filler();

      // tail bar//
      tail_Bar.fill_Amount();
      tail_Bar.Tailfill_Amount();
   }

   // use in button events //
   public void TakeDamage()
   {
      fill_Bar.TakeDamage();
      slider_Bar.TakeDamage();
      circular_Bar.TakeDamage();
      block_Bar.TakeDamage();
      tail_Bar.TakeDamage();
      heart_Bar.TakeDamage();
      number_Bar.TakeDamage();
      
   }

   public void GainHeal()
   {
      fill_Bar.GainHealth();
      slider_Bar.GainHealth();
      circular_Bar.GainHealth();
      block_Bar.GainHealth();
      tail_Bar.GainHealth();
      heart_Bar.GainHealth();
      number_Bar.GainHealth();

   }
}
