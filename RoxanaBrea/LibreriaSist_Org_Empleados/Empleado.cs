namespace LibreriaSist_Org_Empleados
{
    public abstract class Empleado
    {
        protected string nombre;
        protected double salario;
        protected string departamento;
        protected int antiguedad;

        protected Empleado(string nombre, double salario, string departamento, int antiguedad)
        {
            this.nombre = nombre;
            this.salario = salario;
            this.departamento = departamento;
            this.antiguedad = antiguedad;
        }


        public abstract string Trabajar();

        public virtual string MostrarInfo()
        {
            return $"Nombre: {nombre} - Salario: {salario} - Departamento{departamento} - Antiguedad{antiguedad}";
        }











    }
}
