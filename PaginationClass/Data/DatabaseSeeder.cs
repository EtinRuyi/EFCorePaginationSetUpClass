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
                    //new Items { Name = "Bible 11", Description = "wertyuiolkjhgfdsdfvbnbvasdfghjnbvcxjffjvfdnvuienbsadbbvadsghbuddnfudhjbhbdhbvdbhbvhbsdb" },
                    //new Items { Name = "Water Bottle 12", Description = "fjnvfdjnvhdhv dhb vgcb bdhvbzhdbxhcjbvdzshbcvgjghsjcbhgdbschdgfuerhfiycbdsiudbfsdiyb " },
                    //new Items { Name = "Locker 13", Description = "Desjdvhsbdhbvcdjsfnhdvszhbghbrvbzdchjbvhdbvhzhbvhdbvcription" },
                    //new Items { Name = "Bunk 14", Description = "bdubvubsdhgbfvsdbozjvbdzscvsdhgjvfbdkjnbjfnhisnfvjncvjdnuiubvidsbsvdvcdjkvkh" },
                    //new Items { Name = "Teacher 15", Description = "fnjbvhjbdhbchjdcbfhbdhbckjzbxhcjbvhdkbfvjchbhgzxbgcvdn cvjlxchzjbvh" },
                    //new Items { Name = "Charita 16", Description = "jncvhjdhcbxzhbxdhchbx hjjnvzdjcnvhchxbhgvghxdgcgvzgxhvczh" },
                    //new Items { Name = "Police 17", Description = "Descfjnvhbzdjvbhjdfbhvbzghdcghvgvdvc zds gvhsdbvhbdvhdhbivhbibdgizription" },
                    //new Items { Name = "Newyton 18", Description = "Descrbcudbvsdiyvzdbisbgvzhjcbhvdbcbzhjdvcgdc vljdnudbfbdvuvdkvdkhsgiption" },
                    //new Items { Name = "BabyGirl 19", Description = "Defhbvkhfbvjknfdlvnouirhlejodanoenbofnghb gjnkfuyugehfb udnuignurhdkjnvuidu dfhyudhfherbvyudbscription" },
                    //new Items { Name = "Oluchi 20", Description = "Desfniun ruguoirhuiorhuoyhtrouhouihgfuor ehgfyuheufiretfdhiorjphiruiohrugcription" },
                    // Add more items as needed
                };

                _context.Items.AddRange(items);
                _context.SaveChanges();
            }
        }
    }
}
