using System;

[Serializable]
public struct Stats {
    int hp;
    int mana;

    public Stats(int hp, int mana) {
        this.hp = hp;
        this.mana = mana;
    }
}