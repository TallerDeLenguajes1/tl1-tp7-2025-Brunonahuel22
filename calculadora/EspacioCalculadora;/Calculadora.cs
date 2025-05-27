namespace EspacioCalculadora
{
    public class Calculadora
    {

        public int dato;

        public Calculadora()
        {
            this.dato = 0;
        }

        //Metodos
        public void Sumar(int valor)
        {
            dato += valor;
        }
        public void Restar(int valor)
        {
            dato -= valor;
        }
        public void Multiplicar(int valor)
        {
            dato *= valor;
        }
        public void Dividir(int valor)
        {
            dato = valor / dato;
        }

    }
}