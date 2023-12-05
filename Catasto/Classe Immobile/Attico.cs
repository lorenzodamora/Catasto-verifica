using System;

namespace Catasto
{
	internal class Attico : Abitazione
	{
		private float _terrazzo;
		/// <summary> In metri quadrati. </summary>
		public float SuperficieTerrazzo
		{
			get => _terrazzo;
			private set
			{
				if(value > 0) _terrazzo = value;
				else throw new ArgumentException("superficie mq terrazzo > 0");
			}
		}

		public Attico() : base() => _terrazzo = 1;

		public Attico(float superficie, string particella, short categoria, short numVani, float superficieTerrazzo)
			: base(superficie, particella, categoria, numVani) => SuperficieTerrazzo = superficieTerrazzo;

		public Attico(Attico abit) : this (abit.Superficie,
			abit.Particella,
			abit.Categoria,
			abit.NumVani,
			abit.SuperficieTerrazzo) { }

		public new Attico Clone() => (Attico)MemberwiseClone(); //new ?

		public override bool Equals(object obj) => Equals(obj as Attico);

		public bool Equals(Attico imm)
			=> base.Equals(imm) && SuperficieTerrazzo == imm.SuperficieTerrazzo;

		public override int GetHashCode() => (Superficie, Particella, Categoria, NumVani, SuperficieTerrazzo).GetHashCode();

		public override string ToString() => $"{base.ToString()};{NumVani}";

		public override float RenditaCatastale()
		{
			float f = base.RenditaCatastale();
			return f + f*SuperficieTerrazzo*2/100;
		}
	}
}
