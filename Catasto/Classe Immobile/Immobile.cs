using System;

namespace Catasto
{
	internal class Immobile : IEquatable<Immobile>
	{
		private float _superficie;
		/// <summary> In metri quadrati. </summary>
		public float Superficie
		{
			get => _superficie;
			private set
			{
				if(value > 0) //valore minimo?
					_superficie = value;
				else throw new ArgumentException("superficie mq > 0");
			}
		}

		private string _particella;
		/// <summary> Identificativo numerico dell'immobile. </summary>
		public string Particella
		{
			get => _particella;
			private set
			{
				//controlla se ci sono solo digit numerici
				if(System.Linq.Enumerable.All(value, char.IsDigit) && !string.IsNullOrEmpty(value))
					_particella = value;
				else throw new ArgumentException("Il codice deve essere esclusivamente numerico [0-9]");
			}
		}

		private short _categoria;
		/// <summary> Da 1 a 5. </summary>
		public short Categoria
		{
			get => _categoria;
			private set
			{
				if(value < 1 || value > 5) throw new ArgumentException("categoria tra 1 e 5");
				_categoria = value;
			}
		}

		public Immobile()
		{
			Superficie = 10f;
			Particella = "1";
			Categoria = 1;
		}

		public Immobile(float superficie, string particella, short categoria)
		{
			Superficie = superficie;
			Particella = particella;
			Categoria = categoria;
		}

		public Immobile(Immobile immobile)
			: this(immobile.Superficie, immobile.Particella, immobile.Categoria) { }

		public Immobile Clone() => (Immobile)MemberwiseClone();

		public override bool Equals(object obj) => Equals(obj as Immobile);

		public bool Equals(Immobile imm)
			=> imm != null && Superficie == imm.Superficie && Particella == imm.Particella && Categoria == imm.Categoria;

		public override int GetHashCode() => (Superficie, Particella, Categoria).GetHashCode();

		public override string ToString() => $"{Superficie};{Particella};{Categoria}";

		public virtual float RenditaCatastale() => Superficie * Categoria;
	}
}
