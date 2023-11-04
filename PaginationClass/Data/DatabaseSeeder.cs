using PaginationClass.Model;

namespace PaginationClass.Data
{
    public class DatabaseSeeder
    {
        private readonly PaginationDbContext _context;

        public DatabaseSeeder(PaginationDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Items.Any())
            {
                // Add dummy data to the Items table
                var items = new[]
                {
                    new Items { Name = "Car 1", Description = "wertyuiolkjhgfdsdfvbnbvasdfghjnbvcxjffjvfdnvuienbsadbbvadsghbuddnfudhjbhbdhbvdbhbvhbsdb" },
                    new Items { Name = "House 2", Description = "fjnvfdjnvhdhv dhb vgcb bdhvbzhdbxhcjbvdzshbcvgjghsjcbhgdbschdgfuerhfiycbdsiudbfsdiyb " },
                    new Items { Name = "Germany 3", Description = "Desjdvhsbdhbvcdjsfnhdvszhbghbrvbzdchjbvhdbvhzhbvhdbvcription" },
                    new Items { Name = "Austrailia 4", Description = "bdubvubsdhgbfvsdbozjvbdzscvsdhgjvfbdkjnbjfnhisnfvjncvjdnuiubvidsbsvdvcdjkvkh" },
                    new Items { Name = "Laptop 5", Description = "fnjbvhjbdhbchjdcbfhbdhbckjzbxhcjbvhdkbfvjchbhgzxbgcvdn cvjlxchzjbvh" },
                    new Items { Name = "Christmas 6", Description = "jncvhjdhcbxzhbxdhchbx hjjnvzdjcnvhchxbhgvghxdgcgvzgxhvczh" },
                    new Items { Name = "Nigeria 7", Description = "Descfjnvhbzdjvbhjdfbhvbzghdcghvgvdvc zds gvhsdbvhbdvhdhbivhbibdgizription" },
                    new Items { Name = "Truck 8", Description = "Descrbcudbvsdiyvzdbisbgvzhjcbhvdbcbzhjdvcgdc vljdnudbfbdvuvdkvdkhsgiption" },
                    new Items { Name = "Table 9", Description = "Defhbvkhfbvjknfdlvnouirhlejodanoenbofnghb gjnkfuyugehfb udnuignurhdkjnvuidu dfhyudhfherbvyudbscription" },
                    new Items { Name = "Church 10", Description = "Desfniun ruguoirhuiorhuoyhtrouhouihgfuor ehgfyuheufiretfdhiorjphiruiohrugcription" },
                    // Add more items as needed
                };

                _context.Items.AddRange(items);
                _context.SaveChanges();
            }
        }
    }
}
