namespace G12_20250227
{
    internal class Program
    {
        static void Main()
        {
            Car[] cars = new Car[]
            {
                new Car { Make = "Toyota", Model = "Camry", Year = 2020 },
                new Car { Make = "Honda", Model = "Civic", Year = 2019 },
                new Car { Make = "Ford", Model = "Mustang", Year = 2021 },
                new Car { Make = "Chevrolet", Model = "Malibu", Year = 2018 },
                new Car { Make = "Nissan", Model = "Altima", Year = 2022 },
                new Car { Make = "BMW", Model = "3 Series", Year = 2020 },
                new Car { Make = "Audi", Model = "A4", Year = 2019 },
                new Car { Make = "Mercedes-Benz", Model = "C-Class", Year = 2021 },
                new Car { Make = "Volkswagen", Model = "Passat", Year = 2018 },
                new Car { Make = "Hyundai", Model = "Elantra", Year = 2022 }
            };


            Book[] books = new Book[]
            {
                new Book { Author = "Jane Austen", Title = "Pride and Prejudice", Pages = 213 },
                new Book { Author = "F. Scott Fitzgerald", Title = "The Great Gatsby", Pages = 314 },
                new Book { Author = "Harper Lee", Title = "To Kill a Mockingbird", Pages = 344 },
                new Book { Author = "George Orwell", Title = "1984", Pages = 284 },
                new Book { Author = "C. S. Lewis", Title = "The Lion, the Witch and the Wardrobe", Pages = 250 }
            };


            ArrayHelper.Sort(cars);
            ArrayHelper.Sort(books);

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.Clear();

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]);
            }
        }
    }
}
