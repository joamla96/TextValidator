﻿using System;
using System.Text.RegularExpressions;

namespace TextValidator {
	public class Validator {
		public bool Text(string v) {
			return Regex.IsMatch(v, @"^[a-zA-Z]+$");
		}

		public bool Number(string input) {
			return Regex.IsMatch(input, @"^[0-9]+$");
		}

		public bool Date(string input) {
			DateTime Result;
			return DateTime.TryParse(input, out Result);
		}
	}
}
