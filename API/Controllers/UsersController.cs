using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using API.SQLConnection;
using System.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IDBConnection _isqlConnection;
        private readonly DataContext _context; // here we have used dependency injection so that we can access the data from the DataContext class.
        public UsersController(DataContext context, IDBConnection connection)
        {
            _isqlConnection = connection;
            _context = context;
        }
     
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>>GetUsers() // we are going to be returning a type of action result. 
        {            
            return await _context.Users.ToListAsync();                          
        }
        [HttpGet("{id}")]
        public async  Task<ActionResult<AppUser>> GetUser(int id) // we are going to be returning a type of action result. 
        {
            return await _context.Users.FindAsync(id);            
        }
    }
}
