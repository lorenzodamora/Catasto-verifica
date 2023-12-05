using System;

namespace Catasto
{
	internal class Abitazione : Immobile
	{
		private short _vani;
		public short NumVani
		{
			get => _vani;
			private set
			{
				if(value > 0) _vani = value;
				else throw new ArgumentException("numero vani superiore a 0");
			}
		}

		public Abitazione() : base() => _vani = 1;

		public Abitazione(float superficie, string particella, short categoria, short numVani)
			: base(superficie, particella, categoria) => NumVani = numVani;

		public Abitazione(Abitazione abit) : this
			(abit.Superficie, abit.Particella, abit.Categoria, abit.NumVani)
		{ }

		public new Abitazione Clone() => (Abitazione)MemberwiseClone(); //new ?

		public override bool Equals(object obj) => Equals(obj as Abitazione);

		public bool Equals(Abitazione imm)
			=> base.Equals(imm) && NumVani == imm.NumVani;

		public override int GetHashCode() => (Superficie, Particella, Categoria, NumVani).GetHashCode();

		public override string ToString() => $"{base.ToString()};{NumVani}";

		public override float RenditaCatastale() => base.RenditaCatastale() * NumVani;
	}
}
