using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block_Bar : MonoBehaviour
{
    public float player_CurrentHealth = 100;
    public float player_MaxHealth = 100;

    Health_System player_health;

    public Image[] fill_Blocks;


   
    void Start()
    {
      // construct player_health instance from health system//
      player_health = new Health_System(player_CurrentHealth,player_MaxHealth);
      //Debug.Log(player_health._CurrentHealth);    
    }
    
    public void Block_Filler()
    {
      for (int i = 0; i < fill_Blocks.Length; i++)
      {
        fill_Blocks[i].enabled = !DisplayHealthPoint(player_health._CurrentHealth,i);
      }
    }

    bool DisplayHealthPoint(float _health , int Point_Number)
    {
        return((Point_Number * 10) >= _health);
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
