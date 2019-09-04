using System;

[Serializable]
public struct Stats {
    public int attack;
    public int hp;
    public int mana;

    public Stats(int hp, int mana, int attack) {
        this.hp = hp;
        this.mana = mana;
        this.attack = attack;
    }
}