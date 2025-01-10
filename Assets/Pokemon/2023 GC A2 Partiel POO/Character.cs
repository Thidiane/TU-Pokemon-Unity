﻿using System;

namespace _2023_GC_A2_Partiel_POO.Level_2
{
    /// <summary>
    /// Définition d'un personnage
    /// </summary>
    public class Character
    {
        bool isAlive;
        /// <summary>
        /// Stat de base, HP
        /// </summary>
        int _baseHealth = 100;
        /// <summary>
        /// Stat de base, ATK
        /// </summary>
        int _baseAttack = 50;
        /// <summary>
        /// Stat de base, DEF
        /// </summary>
        int _baseDefense = 30;
        /// <summary>
        /// Stat de base, SPE
        /// </summary>
        int _baseSpeed = 20;
        /// <summary>
        /// Type de base
        /// </summary>
        TYPE _baseType;

        public Character(int baseHealth, int baseAttack, int baseDefense, int baseSpeed, TYPE baseType)
        {
            _baseHealth = baseHealth;
            _baseAttack = baseAttack;
            _baseDefense = baseDefense;
            _baseSpeed = baseSpeed;
            _baseType = baseType;
        }
        /// <summary>
        /// HP actuel du personnage
        /// </summary>
        public int CurrentHealth { get; private set; } = 100;

        public TYPE BaseType { get => _baseType;}
        /// <summary>
        /// HPMax, prendre en compte base et equipement potentiel
        /// </summary>
        public int MaxHealth
        {
            get
            {
                return _baseHealth;
                throw new NotImplementedException();
            }
            
        }
        /// <summary>
        /// ATK, prendre en compte base et equipement potentiel
        /// </summary>
        public int Attack
        {
            get
            {
                return _baseAttack;
                throw new NotImplementedException();
            }
        }
        /// <summary>
        /// DEF, prendre en compte base et equipement potentiel
        /// </summary>
        public int Defense
        {
            get
            {
                return _baseDefense;
                throw new NotImplementedException();
            }
        }
        /// <summary>
        /// SPE, prendre en compte base et equipement potentiel
        /// </summary>
        public int Speed
        {
            get
            {
                return _baseSpeed;
                throw new NotImplementedException();
            }
        }


        /// <summary>
        /// Equipement unique du personnage
        /// </summary>
        public Equipment CurrentEquipment { get; private set; }

        /// <summary>
        /// null si pas de status
        /// </summary>
        public StatusEffect CurrentStatus { get; private set; }

        public bool IsAlive => throw new NotImplementedException();


        /// <summary>
        /// Application d'un skill contre le personnage
        /// On pourrait potentiellement avoir besoin de connaitre le personnage attaquant,
        /// Vous pouvez adapter au besoin
        /// </summary>
        /// <param name="s">skill attaquant</param>
        /// <exception cref="NotImplementedException"></exception>
        public void ReceiveAttack(Skill s)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Equipe un objet au personnage
        /// </summary>
        /// <param name="newEquipment">equipement a appliquer</param>
        /// <exception cref="ArgumentNullException">Si equipement est null</exception>
        public void Equip(Equipment newEquipment)
        {
            CurrentEquipment = newEquipment;
            _baseHealth += newEquipment.BonusHealth;
            _baseAttack += newEquipment.BonusAttack;
            _baseDefense += newEquipment.BonusDefense;
            _baseSpeed += newEquipment.BonusSpeed;
            if(newEquipment == null)
            {
                throw new NotImplementedException("pas equipement null");
            }
        }
        /// <summary>
        /// Desequipe l'objet en cours au personnage
        /// </summary>
        public void Unequip()
        {
            CurrentEquipment = null;
            _baseHealth = 100;
            _baseAttack = 50;
            _baseDefense = 30;
            _baseSpeed = 20;
            if ( CurrentEquipment != null )
            {
                 throw new NotImplementedException("pas d'équipement");
            }
        }

    }
}
