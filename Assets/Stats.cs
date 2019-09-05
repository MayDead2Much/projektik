using System;

[Serializable]
public struct Stats 
{
    public int attack;
    public int hp;
    public int mana;
    public double attackSpeed;

    public Stats(int hp, int mana, int attack, double attackSpeed) 
    {
        this.hp = hp;
        this.mana = mana;
        this.attack = attack;
        this.attackSpeed = attackSpeed;
    }
}