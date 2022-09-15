using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meilisearch;

namespace MeilisearchConsoleRunner
{
    internal class Program
    {
        public class Movie
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Actor { get; set; }
            public int Age { get; set; }
            public string Genre { get; set; }
        }


        static async Task Main(string[] args)
        {
            var client = new MeilisearchClient("http://localhost:7700", "masterKey");
            var index = await client.Index<Movie>("movies");
            
            
            await index.AddDocuments(new List<Movie> { movie });
            var searchResult = await index.Search<Movie>("Pulp Fiction");
            Console.WriteLine(searchResult);
        }
    }
}
