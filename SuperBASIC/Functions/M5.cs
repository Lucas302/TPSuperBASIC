using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    public class M5 : IFunction
    {
 /*       Renvoie la médiane de A B C D et E
        La médiane est la valeur située au milieu de la liste de 5 valeurs, 
            par exemple, la médiane de(1 2 3 4 5) ou(5 3 4 1 2) est la valeur 3, la médiane de(1 5 25 30 1000) est 25.*/
        public float Apply(List<BasicNumber> arguments)
        {
            List<float> ListParam = new List<float>();
            float mediane;
            int nbArgs = arguments.Count; 
            foreach(var argument in arguments)
            {
                ListParam.Add(argument);
            }
            ListParam.Sort();
            mediane = ListParam[(nbArgs - 1) / 2];
            return mediane;
        }
    }
}
