using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextValidator
{
	public class Validator {
		public bool Text(string v) {
			return Regex.IsMatch(v, @"^[a-zA-Z]+$");
		}

		public bool Number(string input) {
			return Regex.IsMatch(input, @"^[0-9]+$");
		}
	}
}
