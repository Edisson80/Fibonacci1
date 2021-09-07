using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci1
{
    class Fibonacci
    {
        private int numeroLimite;
        private int resultadoDeLaSerie;

        public Fibonacci(int numeroLimite)
        {
            this.numeroLimite = numeroLimite;
        }

        /**
         * @return the numeroLimite
         */
        public int getNumeroLimite()
        {
            return numeroLimite;
        }

        /**
         * @param numeroLimite the numeroLimite to set
         */
        public void setNumeroLimite(int numeroLimite)
        {
            this.numeroLimite = numeroLimite;
        }

        /**
         * @return the resultadoDeLaSerie
         */
        public int getResultadoDeLaSerie()
        {
            return resultadoDeLaSerie;
        }

        /**
         * @param resultadoDeLaSerie the resultadoDeLaSerie to set
         */
        public void setResultadoDeLaSerie(int resultadoDeLaSerie)
        {
            this.resultadoDeLaSerie = resultadoDeLaSerie;
        }

        public void imprimirSerieFibonacci()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("la serie fibonaccio de longitud " + this.numeroLimite + " es: ");
            for (int i = 0; i < this.numeroLimite; i++)
            {
                Console.WriteLine(this.calcularFibonacci(i) + " ");
                this.resultadoDeLaSerie = this.calcularFibonacci(i);
            }
            Console.WriteLine();
            Console.WriteLine("-----------------");

        }

        public void imprimirNumeroPrimo()
        {
            if (this.primo(this.resultadoDeLaSerie))
            {
                Console.WriteLine(this.resultadoDeLaSerie + " el numero resultante es primo");

            }
            else
            {
                Console.WriteLine(this.resultadoDeLaSerie + " EL NUMERO RESULTANTE NO ES PRIMO");
            }
        }

        private bool primo(int numero)
        {
            int contador = 0;
            bool primo = false;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contador += 1;
                }
            }
            if (contador == 2)
            {
                primo = true;

            }
            return primo;
        }

        private int calcularFibonacci(int resultado)
        {
            if (resultado == 0)
            {
                return 0;
            }
            else if (resultado == 1)
            {
                return 1;
            }
            else
            {
                return this.calcularFibonacci(resultado - 1) + this.calcularFibonacci(resultado - 2);
            }
        }
    }
}
