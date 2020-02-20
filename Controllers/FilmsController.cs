using Microsoft.AspNetCore.Mvc;
using StarWarsApiCSharp;
using System;
using System.Text.Encodings.Web;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SWApp.Controllers
{
    public class FilmsController : Controller
    {
        IRepository<Film> filmsRepo = new Repository<Film>();
        
        // 
        // GET: /Films/
        public IActionResult Index()
        {   
            var films = filmsRepo.GetEntities(size: int.MaxValue);

            ViewData["filmList"] = films;
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

            IRepository<Specie> speciesRepo = new Repository<Specie>();
            IRepository<Starship> starshipsRepo = new Repository<Starship>();
            IRepository<Vehicle> vehiclesRepo = new Repository<Vehicle>();
            IRepository<Planet> planetsRepo = new Repository<Planet>();
            IRepository<Person> personsRepo = new Repository<Person>();
            
            IList<string> species = new List<string>();
            foreach (string s in film.Species)
            {
                int specieId = Int32.Parse(Regex.Match(s, @"\d+").Value);
                species.Add(speciesRepo.GetById(specieId).Name);
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