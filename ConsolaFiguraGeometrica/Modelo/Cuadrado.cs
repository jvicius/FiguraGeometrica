using ConsolaFiguraGeometrica.Interface;

namespace ConsolaFiguraGeometrica.Modelo
{
    public class Cuadrado : IFiguraGeometrica
    {
        private float _lado;
        private const string Nombre = "Cuadrado";

        public Cuadrado(float lado)
        {
            _lado = lado;
        }

        public float CalcularArea()
        {
            return _lado * _lado;
        }

        public float CalcularPerimetro()
        {
            return _lado * 4;
        }

        public string ObtenerNombre()
        {
            return Nombre;
        }
    }
}
