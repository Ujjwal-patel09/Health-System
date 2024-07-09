using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart_Bar : MonoBehaviour
{
   public float player_CurrentHealth = 5;
    public float player_MaxHealth = 5;

    Health_System player_health;

    public Image[] heart;


   
    void Start()
    {
      // construct player_health instance from health system//
      player_health = new Health_System(player_CurrentHealth,player_MaxHealth);
      //Debug.Log(player_health._CurrentHealth);    
    }
    
    public void heart_Filler()
    {
      for (int i = 0; i < heart.Length; i++)
      {
        heart[i].enabled = !DisplayHealthPoint(player_health._CurrentHealth,i);
      }
    }

    bool DisplayHealthPoint(float _health , int Point_Number)
    {
        return Point_Number >= _health;
    }

    public void TakeDamage()
    {
      player_health.Damage(1);
      //Debug.Log(player_health._CurrentHealth);
    }

    public void GainHealth()
    {
      player_health.Heal(1);
      //Debug.Log(player_health._CurrentHealth);
    }
}
