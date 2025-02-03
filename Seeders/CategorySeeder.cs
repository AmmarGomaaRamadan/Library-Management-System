namespace Library_Management_System.Seeders
{
    static class CategorySeeder
    {
        public static Category[] categories = new Category[]
        {
            new Category
            {
                Id = 1,
                Name="Computer Science",
                Description="includes computer science books",
                Books=null
            },
               new Category
            {
                   Id = 2,
                Name="Infomation technology",
                Description="includes Infomation technology books",
                Books=null
            }

        };
    }
}
