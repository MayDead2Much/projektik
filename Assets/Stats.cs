using System;

[Serializable]
public struct Stats {
    int hp;
    int mana;
    int attack;

    public Stats(int hp, int mana, int attack) {
        this.hp = hp;
        this.mana = mana;
        this.attack = attack;
    }
}