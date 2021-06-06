using System;

namespace Tarefa5
{
    public class Retangulo : Figura
    {
        private double _base; // atributo
        private double altura;
        public double Base // propriedade
        {
            // leitura do atributo correspondente
            get
            {
                return this._base;
            }

            // escrita do atributo correspondente
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Base inválida");
                }
                else
                {
                    this._base = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public double Altura // propriedade
        {
            // leitura do atributo correspondente
            get
            {
                return this.altura;
            }

            // escrita do atributo correspondente
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Altura inválida");
                }
                else
                {
                    this.altura = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public Retangulo(double Base, double Altura)
        {
            // escrita utilizando método set da propriedade
            this.Base = Base;
            this.Altura = Altura;
        }
        private void AtualizarArea()
        {
            this._area = this.Base * this.altura;
        }
        private void AtualizarPerimetro()
        {
            this._perimetro = 2 * (this.Altura + this.Base);
        }
    }
}