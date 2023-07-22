﻿using Lyrics_Final_Proj.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lyrics_Final_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        // GET: api/<CommentsController>
        [HttpGet]
        [Route("GetAllCommentsArtists/{artistName}")]
        public IEnumerable<Comment> GetCommentsToArtist(string artistName)
        {
            Comment comment = new Comment();
            return comment.CommentsByArtist(artistName);
        }
        
        // GET: api/<CommentsController>
        [HttpGet]
        [Route("GetAllCommentsSongs/{songName}")]
        public IEnumerable<Comment> GetCommentsToSong(string songName)
        {
            Comment comment = new Comment();
            return comment.CommentsBySong(songName);
        }
        

        // GET api/<CommentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CommentsController>
        [HttpPost]
        [Route("CommentToArtist")]
        public int PostCommentToArtist(Comment comment)
        {
            if (comment.Content == "")
            {
                throw new Exception("$Comment is empty$");
            }
                return comment.AddCommentArtist();
        }

        // POST api/<CommentsController>
        [HttpPost]
        [Route("CommentToSong")]
        public int PostCommentToSong(Comment comment)
        {
            if (comment.Content == "")
            {
                throw new Exception("$Comment is empty$");
            }
            return comment.AddCommentSong();
        }

        // PUT api/<CommentsController>/5
        [HttpPut]
        [Route("ChangeCommentToArtist/{idA}")]
        public bool PutContentArtist(int idA, [FromBody] string content)
        {
            return Comment.ChangeCommentArtist(idA,content); 
        }

        [HttpPut]
        [Route("ChangeCommentToSong/{idS}")]
        public bool PutContentSong(int idS, [FromBody] string content)
        {
            return Comment.ChangeCommentSong(idS, content);
        }

        // DELETE api/<CommentsController>/5
        [HttpDelete()]
        [Route("DeleteCommentArtistByID/{idA}")]
        public int DeleteCommentArtist(int idA)
        {
            Comment comment = new Comment();
            return comment.DeleteCommentA(idA);
        }

        // DELETE api/<CommentsController>/5
        [HttpDelete()]
        [Route("DeleteCommentSongByID/{idS}")]
        public int DeleteCommentSong(int idS)
        {
            Comment comment = new Comment();
            return comment.DeleteCommentS(idS);
        }
    }
}
