using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Data.Model
{
	public class AppointmentsAvailable:BaseEntity<int>
	{
		[ForeignKey(nameof(Property))]
		public int PropertyId { get; set; }
		public Property Property { get; set; }
		public DateTime From { get; set; }
		public DateTime To { get; set; }
		public decimal PricePerNight { get; set; }
		public bool IsAvailable { get; set; }
	}
}
