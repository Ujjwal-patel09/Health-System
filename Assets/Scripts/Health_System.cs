using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_System
{
    // Variables //
    private float current_health;
    private float max_health;

    // properties //
    public float _CurrentHealth
    {
       get
       {
          return current_health;
       }
       set
       {
          current_health = value;
       }
    }

    public float _MaxHealth
    {
       get
       {
          return max_health;
       }
       set
       {
          max_health = value;
       }
    }

    // Constructor //
    public Health_System(float CurrentHealth , float MaxHealth)
    {
      current_health = CurrentHealth;
      max_health = MaxHealth;
    }

    // Methods //
    // you can add more function as per game requirement //
    public void Damage(float damage_amount)// damage fuction
    {
       if(current_health > 0)
       {
         current_health -= damage_amount;
       }
    }

    public void Heal(float heal_amount)// Heal function
    {
       if(current_health < max_health)
       {
         current_health += heal_amount;
       }
       if(current_health > max_health)
       {
         current_health = max_health;
       }
    }

}
