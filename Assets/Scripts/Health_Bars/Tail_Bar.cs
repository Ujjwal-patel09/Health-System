using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tail_Bar : MonoBehaviour
{
    public float player_CurrentHealth = 100;
    public float player_MaxHealth = 100;

    Health_System player_health;

    // for bar images //
    public Image fill_Bar;//red
    public Image tail_Bar;// yellow
    float lerpSpeed = 5f;
 
    void Start()
    {
      // construct player_health instance from health system//
      player_health = new Health_System(player_CurrentHealth,player_MaxHealth);
      //Debug.Log(player_health._CurrentHealth);     
    }

    // tail bar //
    public void Tailfill_Amount()
    {
      lerpSpeed = 3f * Time.deltaTime;// increase ammount for harder the effect
      tail_Bar.fillAmount = Mathf.Lerp(tail_Bar.fillAmount,player_health._CurrentHealth / player_health._MaxHealth,lerpSpeed);// for smooth slide     
    }

    // fill bar //
    public void fill_Amount()
    {
      fill_Bar.fillAmount = player_health._CurrentHealth / player_health._MaxHealth;
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
