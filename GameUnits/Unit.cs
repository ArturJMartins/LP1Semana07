namespace GameUnits
{
    // Cria método Move() que imprime no ecrã quantas casas a unidade se moveu
    //Cria a propriedade Cost, do tipo float, abstrata, só de leitura
    //Torna a classe abstrata (porquê?)
    //Propriedade Health deve passar a ser virtual (porquê?)

    // alterado a class de publica para abstract devido à nova propriedade Cost
    abstract class Unit
    {
        private int movement;
        public virtual int Health { get; set; }

        public abstract float Cost { get; } 

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public int Move()
        {
            return movement;
        }
    }
}
