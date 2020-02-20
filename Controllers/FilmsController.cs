using Microsoft.AspNetCore.Mvc;
using StarWarsApiCSharp;
using System;
using System.Text.Encodings.Web;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace SWApp.Controllers
{
    public class FilmsController : Controller
    {
        IRepository<Film> filmsRepo = new Repository<Film>();
        IRepository<Specie> speciesRepo = new Repository<Specie>();
        IRepository<Starship> starshipsRepo = new Repository<Starship>();
        IRepository<Vehicle> vehiclesRepo = new Repository<Vehicle>();
        IRepository<Planet> planetsRepo = new Repository<Planet>();
        IRepository<Person> personsRepo = new Repository<Person>();
        // 
        // GET: /Films/
        public IActionResult Index()
        {   
            ICollection<Film> films = filmsRepo.GetEntities(size: int.MaxValue);
            Film[] titles = new Film[films.Count];
            
            // Reroder films in ascending order by id (in url)
            foreach(Film film in films)
            {
                int id = Int32.Parse(Regex.Match(film.Url, @"\d+").Value) - 1;
                titles[id] = film;
            }

            ViewData["filmList"] = titles;
            return View();
        }

        // 
        // GET: /Films/Details?filmId=1/
        // Requires using System.Text.Encodings.Web;
        public IActionResult Details(string filmId)
        {
            int id = Int32.Parse(Regex.Match(filmId, @"\d+").Value);
            var film = filmsRepo.GetById(id);
            
            ViewData["FilmTitle"] = film.Title;
            ViewData["EpisodeId"] = film.EpisodeId;
            ViewData["OpeningCrawl"] = film.OpeningCrawl;
            ViewData["Director"] = film.Director;
            ViewData["Producer"] = film.Producer;
            ViewData["ReleaseDate"] = film.ReleaseDate;

            
            ICollection<Specie> totalSpecies = speciesRepo.GetEntities(size: int.MaxValue);
            string[] filmSpecies = film.Species.ToArray();  // set to array to refer to each index
                                                            // species list in film is in the same order as entire list

            IList<string> species = new List<string>();
            int i=0;
            foreach (Specie s in totalSpecies)
            {
                if (s.Url == filmSpecies[i])
                {
                    species.Add(s.Name);
                    i++;
                    if (i == filmSpecies.Count())
                    {
                        break;
                    }
                }
                
            }
            ViewData["Species"] = species;

            IList<string> starships = new List<string>();
            foreach (string s in film.Starships)
            {
                int starshipId = Int32.Parse(Regex.Match(s, @"\d+").Value);
                starships.Add(starshipsRepo.GetById(starshipId).Name);
            }
            ViewData["Starships"] = starships;

            IList<string> vehicles = new List<string>();
            foreach (string s in film.Vehicles)
            {
                int vehicleId = Int32.Parse(Regex.Match(s, @"\d+").Value);
                vehicles.Add(vehiclesRepo.GetById(vehicleId).Name);
            }
            ViewData["Vehicles"] = vehicles;

            IList<string> persons = new List<string>();
            foreach (string s in film.Characters)
            {
                int characterId = Int32.Parse(Regex.Match(s, @"\d+").Value);
                persons.Add(personsRepo.GetById(characterId).Name);
            }
            ViewData["Characters"] = persons;

            IList<string> planets = new List<string>();
            foreach (string s in film.Planets)
            {
                int planetId = Int32.Parse(Regex.Match(s, @"\d+").Value);
                planets.Add(planetsRepo.GetById(planetId).Name);
            }
            ViewData["Planets"] = planets;

            return View();
        }
    }
}