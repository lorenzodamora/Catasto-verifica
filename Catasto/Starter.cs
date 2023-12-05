using System;

namespace Catasto
{
	/*
	 * v memorizzare dati immobili
	 * v immobili: superficie mq, particella (num id immobile), categoria (num 1..5).
	 * v immobili si suddividono in:
	 * v - terreni, se fabbricabile;
	 * v - abitazioni, num vani;
	 * v - - attici, + superficie mq del terrazzo. 
	 * v essere possibile calcolare valore rendita catastale:
	 * v - tutti: la rendita base = superficie * categoria;
	 * v - terreni: se terreno fabbricabile -> maggiorazione 30% alla rendita base; se no riduzione 10%
	 * v - abitazioni: rendita base * num vani;
	 * v - attici: maggiorazione al valore abitazione di una percentuale doppia della superficie del terrazzo. (abit + abit*val/100; val = superficie terrazzo * 2)
	 * 
	 * diagramma UML
	 * windows form:
	 * - info immobili, distinguendoli
	 * - visualizzare info di tutti inseriti, compreso valore rendita catastale
	 * - somma rendite catastali di tutti
	 * v - attributi, properties, costruttori, equals, toString, + metodi implementare le richieste
	 * 
	 * array per memorizzare info inserite
	 * 
	 * Avanzato: visualizzare dati immobili con rendita minima e massima.
	 */
	internal static class Starter
	{
		[STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			System.Windows.Forms.Application.Run(new Catasto());
		}
	}
}
