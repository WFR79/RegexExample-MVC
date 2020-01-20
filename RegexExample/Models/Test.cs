using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegexExample.Models
{
	public class Test
	{
		public int TestID { get; set; }
		[RegularExpression(@"[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)")]
		public string ValueExponent { get; set; }
	}
}