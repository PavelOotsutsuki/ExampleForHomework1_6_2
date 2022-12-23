using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleForHomework1_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(2, 10);
            Boss boss = new Boss(5, 5);
            Renderer rendererPlayer = new Renderer();

            rendererPlayer.DrawPosition((Entity)player);
            rendererPlayer.DrawPosition((Entity)boss);
        }
    }

    class Entity
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public char SymbolEntity { get; private set; }

        public Entity(int positionX, int positionY, char symbolEntity)
        {
            PositionX = positionX;
            PositionY = positionY;
            SymbolEntity = symbolEntity;
        }
    }

    class Player : Entity 
    {
        public Player(int positionX, int positionY, char symbolPlayer = '&'): base(positionX, positionY, symbolPlayer) { }
    }

    class Boss: Entity
    {
        public Boss(int positionX, int positionY, char symbolPlayer = '%') : base(positionX, positionY, symbolPlayer) { }
    }

    class Renderer
    {
        public void DrawPosition(Entity entity)
        {
            Console.SetCursorPosition(entity.PositionX, entity.PositionY);
            Console.Write(entity.SymbolEntity);
        }
    }
}
