using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_tests
{
    public static class ClasseChaine
    {
        public static string RetourneInitiales(string prenom, string nom)
        {
            string initiale = "";
            if (string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(nom))
            {
                throw new ArgumentNullException();
            }

            string[] listPrenom = prenom.Split(' ');
            string[] listNom = nom.Split(' ');

            foreach (var item in listPrenom)
            {
                initiale += item.Substring(0, 1);
            }

            foreach (var item in listNom)
            {
                initiale += item.Substring(0, 1);
            }

            return initiale;
        }
    }
}
