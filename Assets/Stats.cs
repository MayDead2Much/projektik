using System;

[Serializable]
public struct Stats 
{
    public int attack;
    public int hp;
    public int mana;
    public float attackSpeed;
    public float hitRadius;

    public Stats(int hp, int mana, int attack, float attackSpeed, float hitRadius) 
    {
        this.hp = hp;
        this.mana = mana;
        this.attack = attack;
        this.attackSpeed = attackSpeed;
        this.hitRadius = hitRadius;
    }
}