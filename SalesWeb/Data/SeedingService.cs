using System;
using System.Linq;
using SalesWeb.Models;
using SalesWeb.Models.Enums;

namespace SalesWeb.Data
{
	public class SeedingService
	{
		private SalesWebContext _context;

		public SeedingService(SalesWebContext context)
		{
			_context = context;
		}

		public void Seed()
		{
			if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
			{
				return; //DB has been seeded
			}

			Department d1 = new Department(1, "Computers");
			Department d2 = new Department(2, "Eletronics");
			Department d3 = new Department(3, "Gamers");
			Department d4 = new Department(4, "Develops");
			Department d5 = new Department(5, "Books");

			Seller s1 = new Seller(1, "Pedro 0", "pedroeternalss@gmail.com", new DateTime(1996, 10, 21), 1000.0, d1);
			Seller s2 = new Seller(2, "Pedro 1", "pedroeternalss@gmail.com", new DateTime(1996, 10, 21), 1000.0, d2);
			Seller s3 = new Seller(3, "Pedro 2", "pedroeternalss@gmail.com", new DateTime(1996, 10, 21), 1000.0, d3);
			Seller s4 = new Seller(4, "Pedro 3", "pedroeternalss@gmail.com", new DateTime(1996, 10, 21), 1000.0, d4);
			Seller s5 = new Seller(5, "Pedro 4", "pedroeternalss@gmail.com", new DateTime(1996, 10, 21), 1000.0, d5);

			SalesRecord r1 = new SalesRecord(1, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Billed, s1);
			SalesRecord r2 = new SalesRecord(2, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Billed, s2);
			SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Billed, s3);
			SalesRecord r4 = new SalesRecord(4, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Billed, s4);
			SalesRecord r5 = new SalesRecord(5, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Billed, s5);
			SalesRecord r6 = new SalesRecord(6, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Billed, s2);
			SalesRecord r7 = new SalesRecord(7, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Billed, s3);
			SalesRecord r8 = new SalesRecord(8, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Billed, s4);
			SalesRecord r9 = new SalesRecord(9, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Billed, s5);
			SalesRecord r10 = new SalesRecord(10, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Billed, s3);
			SalesRecord r11 = new SalesRecord(11, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Billed, s1);


			_context.Department.AddRange(d1, d2, d3, d4, d5);
			_context.Seller.AddRange(s1, s2, s3, s4, s5);
			_context.SalesRecord.AddRange(
				r1, r2, r3, r4, r5,
				r6, r7, r8, r9, r10, r11);

			_context.SaveChanges();
		}
	}
}
