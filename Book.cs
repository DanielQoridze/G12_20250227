namespace G12_20250227
{
    class Book : Comparables
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public override string ToString()
        {
            return $"{Title} by {Author} ({Pages})";
        }

        public override int CompareTo(object obj)
        {
            if (obj is not Book book)
            {
                throw new Exception("invalid class");
            }

            if (Pages < book.Pages)
            {
                return -1;
            }

            if (Pages > book.Pages)
            {
                return 1;
            }

            return 0;
        }
    }
}
