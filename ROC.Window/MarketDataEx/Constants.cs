﻿namespace MarketData
{
	public static class Constants
	{
		internal static class Utility
		{
			internal static bool TryGetName(string[] codes, string[] names, string code, out string name)
			{
				int index = System.Array.IndexOf(codes, code);
				if (index >= 0) {
					name = names[index];
					return true;
				}
				name = string.Empty;
				return false;
			}
		}

		public static class L2PartipcantCodeCTA
		{
			public enum ID
			{
				AmericanStockExchange = 0,
				BostonStockExchange,
				NationalStockExchange,
				NASDAlternativeDisplayFacility,
				ISEStockExchange,
				ChicagoStockExchange,
				NewYorkStockExchange,
				PacificStockExchange,
				NasdaqStockExchangeT,
				ChicagoBoardOptionsExchange,
				PhiladelphiaStockExchange,
				BATSExchange
			};

			public static string[] Codes => _codes;

			public static string GetCode(ID which) => _codes[(int)which];
			public static string GetName(ID which) => _names[(int)which];
			public static bool TryGetName(string code, out string name) => Utility.TryGetName(_codes, _names, code, out name);

			private static string[] _codes = new string[] { "A", "B", "C", "D", "I", "M", "N", "P", "T", "W", "X", "Z" };
			private static string[] _names = new string[] {
				"NYSE Amex",
				"NASDAQ OMX BX",
				"National Stock Exchange",
				"FINRA",
				"International Securities Exchange",
				"Chicago Stock Exchange",
				"New York Stock Exchange",
				"NYSE Arca",
				"NASDAQ OMX",
				"CBOE Stock Exchange",
				"NASDAQ OMX PHLX",
				"BATS Trading"
			};
		}

		public static class L2PartipcantCodeNasdaq
		{
			public enum ID
			{
				AmericanStockExchange = 0,
				BostonStockExchange,
				NationalStockExchange,
				NASDAlternativeDisplayFacility,
				MarketIndependent,
				ISEStockExchange,
				EDGAExchange,
				EDGXExchange,
				ChicagoStockExchange,
				NewYorkStockExchange,
				PacificStockExchange,
				NasdaqStockExchangeQ,
				NasdaqStockExchangeT,
				ChicagoBoardOptionsExchange,
				PhiladelphiaStockExchange,
				BATSYExchange,
				BATSExchange
			};

			public static string[] Codes => _codes;

			public static string GetCode(ID which) => _codes[(int)which];
			public static string GetName(ID which) => _names[(int)which];
			public static bool TryGetName(string code, out string name) => Utility.TryGetName(_codes, _names, code, out name);

			private static string[] _codes = new string[] { "A", "B", "C", "D", "E", "I", "J", "K", "M", "N", "P", "Q", "W", "X", "Y", "Z" };
			private static string[] _names = new string[] {
				"NYSE Amex",
				"NASDAQ OMX BX",
				"National Stock Exchange",
				"FINRA ADF",
				"Market Independent (Generated by SIP)",
				"International Securities Exchange",
				"EDGA Exchange, Inc",
				"EDGX Exchange, Inc",
				"Chicago Stock Exchange",
				"NYSE Euronext",
				"NYSE Arca Group",
				"NASDAQ OMX",
				"CBOE Stock Exchange",
				"NASDAQ OMX PHLX",
				"BATS Y Exchange, Inc",
				"BATS Exchange, Inc"
			};
		}

		public static class OptionDataSource
		{
			public const string OPRA = "OPRA";
			public const string OPRANBBO = "OPRANBBO";
			public const string CME = "CME";
			public const string ICE = "ICE";
		}
	}
}
