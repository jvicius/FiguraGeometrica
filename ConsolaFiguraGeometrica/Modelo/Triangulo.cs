using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolaFiguraGeometrica.Interface;

namespace ConsolaFiguraGeometrica.Modelo
{
    public class Triangulo : IFiguraGeometrica
    {
        private float _lado;
        private float _altura;
        private const string Nombre = "Triangulo Equilatero";

        public Triangulo(float lado, float altura)
        {
            _lado = lado;
            _altura = altura;
        }

        public float CalcularArea()
        {
            return (_lado * _altura) / 2;
        }

        public float CalcularPerimetro()
        {
            return _lado * 3;
        }

        public string ObtenerNombre()
        {
            return Nombre;
        }
    }
}
