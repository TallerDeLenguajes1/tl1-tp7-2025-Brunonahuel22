namespace EspacioCalculadora
{
    class Calculadora
    {
        private int _dato;
        private int _resultado;

        public int Dato
        {
            get => _dato;
            set => _dato = value;
        }


        public Calculadora(int valorInicial)
        {
            _dato = valorInicial;
        }

        public void Sumar(int parametro_sumar)
        {
            _dato += parametro_sumar;
        }
        public void Restar(int parametro_sumar)
        {
            _dato += parametro_sumar;
        }
        public void Multiplicar(int parametro_sumar)
        {
            _dato += parametro_sumar;
        }

        public void Dividir(int divisor)
        {
            if (divisor != 0)
            {
                _dato /= divisor;
            }
            else
            {
                Console.WriteLine("¡Error! No se puede dividir por cero.");
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine(_dato);
        }
        public void Limpiar()
        {
            _dato = 0;
        }


    }
}