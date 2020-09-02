using TPjeu.Accessoire;
using TPjeu.Classes;

namespace TPjeu.Apptitudes
{
    public class Competences
    {
        public static int frappeDeCompetence()
        {
            var recharge = De.lancerDe(10);
            var competence = De.lancerDe(6);
            var degats = De.lancerDe(26);

            if (recharge < 5)
            {
                Narration.competenceRecharge();
                if (competence <= 3)
                {
                    switch (LevelBoss.hero)
                    {
                        case Guerrier _:
                            Narration.competenceGuerrier();
                            return degats = 120;
                        case Archer _:
                            Narration.competenceArcher();
                            return degats = 120; 
                        case Mage _:
                            Narration.competenceMage();                            
                            return degats = 120;
                        default:
                            Narration.competenceLambda();
                            return degats = 120;
                    }
                }
                else
                {
                    Narration.competenceEchoue();
                }
            }
            return degats;
        }
    }
}