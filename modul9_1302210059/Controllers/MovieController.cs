using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace modul9_1302210059.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController
    {
        // Daftar movie
        static public List<Movie> listMovie = new List<Movie> {
            new Movie("The Shawshank Redemption", "Frank Darabont", new List<string> {"Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"},
               "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."),
            new Movie("The Godfather", "Francis Ford Coppola", new List<string> { "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"},
               "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movie("The Dark Knight", "Christopher Nolan", new List<string> {"Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"},
               "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
        };

        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return listMovie;
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return listMovie[id];
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            listMovie.Add(value);
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMovie.RemoveAt(id);
        }
    }
}