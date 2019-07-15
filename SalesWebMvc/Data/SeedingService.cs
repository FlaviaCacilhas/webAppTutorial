using System;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Models.Enums;
using System.Threading.Tasks;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _contex;

        public SeedingService(SalesWebMvcContext contex)
        {
            _contex = contex;
        }

        public void Seed()
        {
            if(_contex.Department.Any() || _contex.Seller.Any() || _contex.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Marco Paulo", "marcopaulo@computers.com", new DateTime(1978,09,09), 2400, d1);
            Seller s2 = new Seller(2, "Bob Brown", "bobbrown@eletronics.com", new DateTime(1980, 03, 25), 2000, d2);
            Seller s3 = new Seller(3, "João Maia", "joaomaia@fashion.com", new DateTime(1973, 11, 30), 1500, d3);
            Seller s4 = new Seller(4, "Ana Machado", "anamachado@books.com", new DateTime(1985, 07, 15), 2400, d4);
            Seller s5 = new Seller(5, "Fabiola Faria", "fabifaria@fashion.com", new DateTime(1976, 01, 21), 1900, d3);
            Seller s6 = new Seller(6, "Maria Silva", "mariasilva@computers.com", new DateTime(1985, 10, 17), 2100, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2019, 05, 22), 5000, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2019, 06, 10), 200, SaleStatus.Billed, s4); 
            SalesRecord r3 = new SalesRecord(3, new DateTime(2019, 03, 20), 700, SaleStatus.Billed, s3); 
            SalesRecord r4 = new SalesRecord(4, new DateTime(2019, 04, 15), 399, SaleStatus.Billed, s2); 
            SalesRecord r5 = new SalesRecord(5, new DateTime(2019, 02, 12), 2000, SaleStatus.Billed, s6); 
            SalesRecord r6 = new SalesRecord(6, new DateTime(2019, 07, 11), 300, SaleStatus.Billed, s4); 
            SalesRecord r7 = new SalesRecord(7, new DateTime(2019, 03, 29), 199, SaleStatus.Billed, s2); 
            SalesRecord r8 = new SalesRecord(8, new DateTime(2019, 05, 14), 499, SaleStatus.Billed, s3); 
            SalesRecord r9 = new SalesRecord(9, new DateTime(2019, 01, 10), 3500, SaleStatus.Billed, s5); 
            SalesRecord r10 = new SalesRecord(10, new DateTime(2019, 05, 17), 789, SaleStatus.Billed, s2); 
            SalesRecord r11 = new SalesRecord(11, new DateTime(2019, 06, 16), 59.99, SaleStatus.Billed, s4);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2019, 04, 28), 679, SaleStatus.Billed, s2); 
            SalesRecord r13 = new SalesRecord(13, new DateTime(2019, 03, 22), 500, SaleStatus.Billed, s2); 
            SalesRecord r14 = new SalesRecord(14, new DateTime(2019, 07, 12), 800, SaleStatus.Billed, s3);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2019, 03, 07), 69.99, SaleStatus.Billed, s5); 
            SalesRecord r16 = new SalesRecord(16, new DateTime(2019, 02, 25), 3400, SaleStatus.Billed, s1); 
            SalesRecord r17 = new SalesRecord(17, new DateTime(2019, 04, 27), 689, SaleStatus.Billed, s3); 
            SalesRecord r18 = new SalesRecord(18, new DateTime(2019, 03, 09), 150, SaleStatus.Billed, s6);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2019, 06, 17), 599, SaleStatus.Billed, s2); 
            SalesRecord r20 = new SalesRecord(20, new DateTime(2019, 05, 02), 870, SaleStatus.Billed, s3); 
            SalesRecord r21 = new SalesRecord(21, new DateTime(2019, 04, 21), 2000, SaleStatus.Billed, s2); 
            SalesRecord r22 = new SalesRecord(22, new DateTime(2019, 04, 25), 200, SaleStatus.Billed, s4); 
            SalesRecord r23 = new SalesRecord(23, new DateTime(2019, 04, 19), 400, SaleStatus.Billed, s2); 
            SalesRecord r24 = new SalesRecord(24, new DateTime(2019, 07, 10), 80, SaleStatus.Billed, s4);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2019, 06, 19), 400, SaleStatus.Billed, s2); 
            SalesRecord r26 = new SalesRecord(26, new DateTime(2019, 03, 16), 856, SaleStatus.Billed, s5);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2019, 01, 22), 798, SaleStatus.Billed, s1); 
            SalesRecord r28 = new SalesRecord(28, new DateTime(2019, 02, 05), 70, SaleStatus.Billed, s4); 
            SalesRecord r29 = new SalesRecord(29, new DateTime(2019, 07, 02), 40, SaleStatus.Billed, s6); 
            SalesRecord r30 = new SalesRecord(30, new DateTime(2019, 06, 18), 30, SaleStatus.Billed, s4);

            _contex.Department.AddRange(d1, d2, d3, d4);

            _contex.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _contex.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9,r10, r11,r12, r13, r14, r15, r16, r17, r18, r19, r20, r21,
                                            r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _contex.SaveChanges();
        }
    }
}
