namespace Formas {
	internal class Program {
		static void Main(string[] args) {
			List<Cuadrado> formas = new List<Cuadrado>();
			formas.Add(new Rectangulo(7, 3));
			formas.Add(new Cuadrado(4));

			Cuadrado c = new Cuadrado(5);
			c.Lado = 6;
			foreach (Cuadrado forma in formas) {
				forma.MostrarInformacion();
			}

		}
	}
}
