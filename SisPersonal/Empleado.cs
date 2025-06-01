namespace EspacioEmpleados
{
    public enum Cargo
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    class Empleado
    {
        public string Nombre;
        public string Apellido;

        public DateTime FechaNacimiento;
        public char EstadoCivil;
        public DateTime FechaIngreso;
        public double Sueldo;
        public Cargo Cargos;

        // Constructor
        public Empleado(string pNombre, string pApellido, DateTime pFecha, char pEstado, DateTime pFechaIngreso, double pSueldo, Cargo pCargo)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.FechaNacimiento = pFecha;
            this.EstadoCivil = pEstado;
            this.FechaIngreso = pFechaIngreso;
            this.Sueldo = pSueldo;
            this.Cargos = pCargo;
        }

        //metodos
        public int Antiguedad()
        {
            DateTime hoy = DateTime.Today;
            int antiguedad = hoy.Year - FechaIngreso.Year;

            if (FechaIngreso.Date > hoy.AddYears(-antiguedad))
            {
                antiguedad--;
            }


            return antiguedad;
        }

        public int CalcularEdad()
        {
            DateTime diaDeHoy = DateTime.Today;
            int edad = diaDeHoy.Year - FechaNacimiento.Year;

            if (FechaNacimiento.Date > diaDeHoy.AddYears(edad))
            {
                edad--;
            }

            return edad;
        }

        public double CalcularSalario()
        {
            // sueldo = sueldoBasico + adicional
            int antiguedad = Antiguedad();
            double incremento;

            if (antiguedad < 20)
            {
                incremento = Sueldo * 0.01 * Antiguedad();
            }
            else
            {
                incremento = Sueldo * 0.25;
            }

            if (Cargos == Cargo.Especialista || Cargos == Cargo.Ingeniero)
            {
                incremento = incremento + (incremento * 0.50);
            }


            double salario = Sueldo + incremento;

            return salario;

        }
    }
}