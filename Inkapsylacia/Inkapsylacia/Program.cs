using System;

namespace Inkapsylacia
{

    class Gun
    {
        private bool isLoaded; //состояние

        private void Reload() //опознает, скрытая реализация
        {
            Console.WriteLine("Заряжаю...");

            isLoaded = true;

            Console.WriteLine("Заряжено!");
        }

        public void Shoot()// управляет выстрелом

        {
            if (!isLoaded)
            {
                Console.WriteLine("Орудие не заряжено!");
                Reload();

            }
            Console.WriteLine("Выстрел\n");
            isLoaded = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Shoot();
        }
    }
}
