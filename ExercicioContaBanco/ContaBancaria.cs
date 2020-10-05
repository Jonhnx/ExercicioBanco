using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioContaBanco {
    class ContaBancaria {
        private readonly double Taxa = 5.00;
        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            NumeroConta = numero;
            TitularConta = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            Deposito(depositoInicial);
        }

        public void Deposito(double deposito) {
            Saldo += deposito;
        }

        public void Saque(double saque) {
            Saldo -= saque - Taxa;
        }

        public override string ToString() {
            return "Conta " + NumeroConta
                + ", Titular : " + TitularConta
                + ", Saldo : $" + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
