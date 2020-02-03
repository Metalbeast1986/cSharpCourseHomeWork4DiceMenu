using System;
using System.Collections.Generic;
using System.Text;

namespace DiceMenu_ND4.Game
{
    class GameScreen
    {
        private int _width;
        private int _height;

        private Hero _hero;
        private List<Enemy> _enemies = new List<Enemy>();

        public GameScreen(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public void SetHero(Hero hero)
        {
            this._hero = hero;
        }


        public void MoveHeroLeft()
        {
            _hero.MoveLeft();
        }

        public void MoveHeroRight()
        {
            _hero.MoveRight();
        }

        public void AddEnemy(Enemy enemy)
        {
            _enemies.Add(enemy);
        }

        public void MoveAllEnemiesDown()
        {
            foreach (Enemy enemy in _enemies)
            {
                enemy.MoveDown();
            }
        }

        public Enemy GetEnemyById(int id)
        {
            foreach (Enemy enemy in _enemies)
            {
                if (enemy.GetId() == id)
                {
                    return enemy;
                }
            }

            return null;
        }

        public void Render()
        {
            _hero.PrintInfo();
            foreach (Enemy enemy in _enemies)
            {
                enemy.PrintInfo();
            }
        }
    }
}
