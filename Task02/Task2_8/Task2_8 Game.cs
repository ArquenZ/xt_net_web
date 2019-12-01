using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_8
{
    class Game
    {        
        Field field;
        List<Enemy> enemys;
        List<Bonus> bonuses;
        List<Obstacle> obstacles;
        Player player;
        public Game()
        {
            field = new Field(800, 600);
            player = new Player();
        }
        //ISpawnable bonus = new Cherry();
    }
    class Player : IMovable
    {
        public void Move()
        {            
        }
        public void GetBonus()
        {
        }
    }
    class Field
    {
        public Field(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Width { get; }
        public int Height { get; }
    }
    abstract class Enemy:IMovable, ISpawnable, IRemovable
    {
        public virtual void Move() { }
        public void Spawn() { }
        public void Remove() { }
    }
    class Bear : Enemy,IMovable
    {
       
    }
    class Wolf : Enemy, IMovable
    {
        
    }
    class Werebear : Bear, IMovable
    {
        public override void Move()
        {
        }
    }
    class Werewolf : Wolf, IMovable
    {
        public override void Move()
        {
        }
    }
    abstract class Bonus:IEatable,ISpawnable,IRemovable
    {        
        public void Spawn() { }
        public void Remove() { }
        public virtual void Boost()
        {
        }
    }
    class Apple : Bonus, IEatable 
    {
        public override void Boost()
        {
        }
    }
    class Orange : Bonus, IEatable
    {
        public override void Boost()
        {
        }
    }
    class Cherry : Bonus, IEatable
    {
        public override void Boost()
        {
        }
    }
    class Heart : Bonus, IEatable
    {
        public override void Boost()
        {
        }
    }
    class Obstacle:ISpawnable,ITerrain 
    {
        public void Spawn()
        {        
        }
        public void Terrain()
        {            
        }
    }
    class Tree:Obstacle
    {

    }
    class Rock:Obstacle
    {

    }
    interface IMovable
    {
        void Move();
    }
    interface IEatable
    {
        void Boost();
    }
    interface ISpawnable 
    {
        void Spawn(); 
    }
    interface IRemovable
    {
        void Remove();
    }
    interface ITerrain
    {
        void Terrain();
    }
}
