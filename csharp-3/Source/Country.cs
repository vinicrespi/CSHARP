using System;

namespace Codenation.Challenge
{
    public class Country
    {

        public State[] Top10StatesByArea()
        {
            State[] states = new State[10];

            states[0] = new State("Amazonas", "AM");
            states[1] = new State("Par�", "PA");
            states[2] = new State("Mato Grosso", "MT");
            states[3] = new State("Minas Gerais", "MG");
            states[4] = new State("Bahia", "BA");
            states[5] = new State("Mato Grosso do Sul", "MS");
            states[6] = new State("Goi�s", "GO");
            states[7] = new State("Maranh�o", "MA");
            states[8] = new State("Rio Grande do Sul", "RS");
            states[9] = new State("Tocantins", "TO");
            
            return states;

            throw new NotImplementedException();
        }
    }
}
