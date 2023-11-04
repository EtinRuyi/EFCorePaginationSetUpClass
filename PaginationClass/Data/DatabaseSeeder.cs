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
                    new Items { Name = "Bible 1", Description = "wertyuiolkjhgfdsdfvbnbvasdfghjnbvcxjffjvfdnvuienbsadbbvadsghbuddnfudhjbhbdhbvdbhbvhbsdb" },
                    new Items { Name = "Water Bottle 2", Description = "fjnvfdjnvhdhv dhb vgcb bdhvbzhdbxhcjbvdzshbcvgjghsjcbhgdbschdgfuerhfiycbdsiudbfsdiyb " },
                    new Items { Name = "Locker 3", Description = "Desjdvhsbdhbvcdjsfnhdvszhbghbrvbzdchjbvhdbvhzhbvhdbvcription" },
                    new Items { Name = "Bunk 4", Description = "bdubvubsdhgbfvsdbozjvbdzscvsdhgjvfbdkjnbjfnhisnfvjncvjdnuiubvidsbsvdvcdjkvkh" },
                    new Items { Name = "Teacher 5", Description = "fnjbvhjbdhbchjdcbfhbdhbckjzbxhcjbvhdkbfvjchbhgzxbgcvdn cvjlxchzjbvh" },
                    new Items { Name = "Charita 6", Description = "jncvhjdhcbxzhbxdhchbx hjjnvzdjcnvhchxbhgvghxdgcgvzgxhvczh" },
                    new Items { Name = "Police 7", Description = "Descfjnvhbzdjvbhjdfbhvbzghdcghvgvdvc zds gvhsdbvhbdvhdhbivhbibdgizription" },
                    new Items { Name = "Newyton 8", Description = "Descrbcudbvsdiyvzdbisbgvzhjcbhvdbcbzhjdvcgdc vljdnudbfbdvuvdkvdkhsgiption" },
                    new Items { Name = "BabyGirl 9", Description = "Defhbvkhfbvjknfdlvnouirhlejodanoenbofnghb gjnkfuyugehfb udnuignurhdkjnvuidu dfhyudhfherbvyudbscription" },
                    new Items { Name = "Oluchi 10", Description = "Desfniun ruguoirhuiorhuoyhtrouhouihgfuor ehgfyuheufiretfdhiorjphiruiohrugcription" },
                    // Add more items as needed
                };

                _context.Items.AddRange(items);
                _context.SaveChanges();
            }
        }
    }
}
