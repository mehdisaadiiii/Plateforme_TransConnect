using System;
using System.Collections.Generic;

namespace Projet_TransConnect_RUFFENACH_SAADI
{
    public class SalarieInterface //pour les stats sur les salariés, pour calculer la moyenne par exemple, et appeler des interfaces car dans la classe static, cela ne marche pas
    {
        List<Salarie> s1 = Entreprise.ObtenirListeSalaries();

        public SalarieInterface()
        {
            List<Salarie> s1 = Entreprise.ObtenirListeSalaries();
        }
    }
}
