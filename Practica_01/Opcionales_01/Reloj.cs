using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcionales_01
{
    public class Reloj
    {
        int horas;
        int minutos;

        public int Horas
        {
            get
            {
                return this.horas;
            }
            set
            {
                if (value <= 11 && value >= 0)
                    this.horas = value;
                else
                    throw new RelojException("La hora indicada no es correcta");
            }
        }

        public int Minutos
        {
            get
            {
                return this.minutos;
            }
            set
            {
                if (value <= 59 && value >= 0)
                    this.minutos = value;
                else
                    throw new RelojException("Los minutos indicados no son correctos");
            }
        }

        /// <summary>
        /// Constructor de reloj con horas y minutos
        /// </summary>
        /// <param name="horas">horas</param>
        /// <param name="minutos">minutos</param>
        public Reloj(int horas, int minutos)
        {
            this.Horas = horas;
            this.Minutos = minutos;
        }

        /// <summary>
        /// Calcula el angulo de las horas 
        /// Primero se multiplica por 5 (cantidad de desplazamiento que tiene cada hora)
        /// Luego se multiplica por 6 (cantidad de grados que equivale cada desplazamiento)
        /// </summary>
        /// <returns>Grados que correponden a las horas </returns>
        public int Calcular_Angulo_Horas()
        {
            int angulo;
            angulo = (this.Horas * 5) * 6;
            return angulo;
        }

        /// <summary>
        /// Calcula el angulo de los minutos
        /// Se multiplica por 6 (cantidad de grados que le corresponde a cada minuto transcurrido)
        /// </summary>
        /// <returns>Grados que corresponden a los minutos</returns>
        public int Calcular_Angulo_Minutos()
        {
            int angulo;
            angulo = this.Minutos* 6;
            return angulo;
        }
    }
}
