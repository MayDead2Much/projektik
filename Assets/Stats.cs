using System;

[Serializable]
public struct Stats {
    public int hp;
    public int mana;

    public Stats(int hp, int mana) {
        this.hp = hp;
        this.mana = mana;
    }
}