using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextValidator {
	
	[TestClass]
	public class ValidatorTests {
		Validator Valid = new Validator();

		[TestMethod]
		public void TextOnly() {
			Assert.IsTrue(Valid.Text("Hello"));
			Assert.IsTrue(Valid.Text("TestIng"));

			Assert.IsFalse(Valid.Text("Hello My Freind"));
			Assert.IsFalse(Valid.Text("H3llo"));
			Assert.IsFalse(Valid.Text("H3llo My Fre1nd"));
		}

		[TestMethod]
		public void NumbersOnly() {
			throw new NotImplementedException();
		}
	}
}
