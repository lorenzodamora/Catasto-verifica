namespace Catasto
{
	internal class Terreno : Immobile
	{
		private bool _isFabbricabile;
		public bool IsFabbricabile
		{
			get => _isFabbricabile;
			private set => _isFabbricabile = value;
		}

		public Terreno() : base() => _isFabbricabile = false;

		public Terreno(float superficie, string particella, short categoria, bool fabbricabile)
			: base (superficie, particella, categoria) => IsFabbricabile = fabbricabile;

		public Terreno(Terreno terreno) : this
			(terreno.Superficie, terreno.Particella, terreno.Categoria, terreno.IsFabbricabile) { }

		public new Terreno Clone() => (Terreno)MemberwiseClone(); //new ?

		public override bool Equals(object obj) => Equals(obj as Terreno);

		public bool Equals(Terreno imm)
			=> base.Equals(imm) && IsFabbricabile == imm.IsFabbricabile;

		public override int GetHashCode() => (Superficie, Particella, Categoria, IsFabbricabile).GetHashCode();

		public override string ToString() => $"{base.ToString()};{IsFabbricabile}";

		public override float RenditaCatastale()
		{
			float f = base.RenditaCatastale();
			return IsFabbricabile ? f + f*30/100 : f - f*10/100;
		}
	}
}
