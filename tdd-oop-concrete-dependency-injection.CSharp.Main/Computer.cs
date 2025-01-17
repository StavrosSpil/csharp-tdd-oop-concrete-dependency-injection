﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_concrete_dependency_injection.CSharp.Main
{
    public class Computer
    {
        private List<Game> installedGames = new List<Game>();
        private PowerSupply powerSupply;

        public Computer(PowerSupply powerSupply)
        {
            this.powerSupply = powerSupply;
        }

        public Computer(PowerSupply powerSupply, List<Game> preInstalled)
        {
            this.powerSupply = powerSupply;
            this.installedGames = preInstalled;
        }

        public void turnOn()
        {
            this.powerSupply.turnOn();
        }

        public void installGame(Game game)
        {
            this.installedGames.Add(game);
        }

        public String playGame(string name)
        {
            foreach (Game g in this.installedGames)
            {
                if (g.Name.Equals(name))
                {
                    return g.start();
                }
            }
            return "Game not installed";
        }

        public List<Game> InstalledGames { get => this.installedGames; }
        public bool IsPcOn { get { return this.powerSupply.Status; } }
    }
}
