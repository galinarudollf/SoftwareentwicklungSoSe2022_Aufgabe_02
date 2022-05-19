using System;
using System.Threading;

namespace Aufgaben02
{
  class A1
  {
	private static readonly int PulseShortDelay = 100;
	private static readonly int PulseLongDelay = 350;
	private static readonly int PulseAfterDelay = 300;
	private static readonly int CharacterDelay = 800;
	private static readonly int SpaceDelay = 1000;

	static void Flash(int Delay)
	{
		Console.BackgroundColor = ConsoleColor.Red;
		Console.Clear();

		Thread.Sleep(Delay);

		Console.BackgroundColor = ConsoleColor.Black;
		Console.Clear();

		Thread.Sleep(A1.PulseAfterDelay);
	}

	static void MorseString(string Value)
	{
		foreach (char Character in Value)
		{
			string Morse = MorseTable.GetMorseCode(Character);
			foreach (char MorseCharacter in Morse)
			{
				switch (MorseCharacter)
				{
				case '.': A1.Flash(A1.PulseShortDelay); break;
				case '-': A1.Flash(A1.PulseLongDelay); break;
				case ' ': Thread.Sleep(A1.SpaceDelay); break;
				}
			}
			Thread.Sleep(A1.CharacterDelay);
		}
	}

	static void Main(string[] args)
	{
		A1.MorseString("SOS");
	}
 }
}
