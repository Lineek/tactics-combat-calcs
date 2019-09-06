using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TacticsCombatCalcs.Classes.Interfaces;

namespace TacticsCombatCalcs.Classes.Base
{
    class BaseCharacter : ICharacter
    {
        public string Name;
        public int Level;

        public int LifePoint;
        public int PhysAttack;
        public int MagicAttack;
        public int Defense;
        public int MagicDefense;
        public int Dodge;
        public int Precision;
        public int Speed;
        public int MovimentPoints;

        public BaseStatus CurrentStatus;


        public void Die()
        {
            throw new NotImplementedException();
        }

        public int LevelDown()
        {
            throw new NotImplementedException();
        }

        public int LevelUp()
        {
            throw new NotImplementedException();
        }

        public int UseActionSkill(IActionSkill actionSkill)
        {
            throw new NotImplementedException();
        }
    }
}
