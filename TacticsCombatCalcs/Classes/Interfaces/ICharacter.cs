using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TacticsCombatCalcs.Classes.Interfaces;

namespace TacticsCombatCalcs.Classes
{
    interface ICharacter
    {
        int UseActionSkill(IActionSkill actionSkill);

        int LevelUp();

        int LevelDown();

        void Die();
    }
}
