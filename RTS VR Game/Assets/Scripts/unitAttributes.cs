using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitAttributes : MonoBehaviour
{
    protected string type {get;set;} 
    protected int hp { get; set; }
    protected int damage { get; set; }
    protected string state { get; set; }
    protected float mvmntSpd { get; set; }
    protected float atkSpd { get; set; }

    //These next values are used when the units state is reset to normal
    //*Note* These values do not change once they are set
    private float nAtk;
    private float nMv;
    private int nDmg;
    private int nHP;


    // Start is called before the first frame update
    void Start()
    {
        state = "normal";
        hp = 0;
        damage = 0;
        mvmntSpd = 0;
        atkSpd = 0;
    }

   void SetStats(int unitHealth, int unitDamage, int move, int attack)
    {
        //When the unit is created its Stats get placed into here
        hp = unitHealth;
        nHP = unitHealth;

        damage = unitDamage;
        nDmg = unitDamage;

        mvmntSpd = move;
        nMv = move;

        atkSpd = attack;
        nAtk = attack;

    }

    void TakeDamage(int damageTaken)
    {
        // When the unit takes damage its hp is altered here
        hp -= damageTaken;
    }

    void Normal()
    {
        damage = nDmg;
        mvmntSpd = nMv;
        atkSpd = nAtk;

    }
    void Retreat ()
    {
        //When a units HP is below a certain amount then this fuction is called which makes the unit move the opposite direction of the enemy

    }

    void Cautious ()
    {
        //When a unit is surrounded by lots of cover and they are by themselves then their movement speed is lowered
        mvmntSpd /= 1.5;
    }

    void Hyped ()

    {
        mvmntSpd *= 1.5;
    }

}
