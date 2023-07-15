﻿using Lyrics_Final_Proj.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lyrics_Final_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<string> GetFavArtists(string mail)
        {
            User user = new User();
            return user.ArtistArr(mail);
        }

        // GET api/<UsersController>/5
        [HttpGet("{Email}")]
        public string Get(string Email)
        {
            return "value";
        }

        [HttpGet]
        [Route("GetUserByEmail/{email}")]
        public User GetUserByEmail(string email)
        {
           return Lyrics_Final_Proj.Models.User.ReadUserByEmail(email);
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public List<User> GetAllUsers()
        {
            return Lyrics_Final_Proj.Models.User.GetAllUsers();
        }

        // Check if user exists
        [HttpPost]
        [Route("Login")]
        public int Login(User user)
        {
            try
            {
                return user.Login();
            }
            catch (Exception ex)
            {
                throw new Exception("User not found");
            }
        }

        [HttpPost]
        [Route("Register")]
        public bool Register([FromBody] User user)
        {
            return user.Register();
        }

        // POST api/<UsersController>
        [HttpPost]
        [Route("UserLikesSong")]
        public bool Post(string email, string songName)
        {
            User user = new User();
            return user.AddSongToFav(email, songName);

        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
