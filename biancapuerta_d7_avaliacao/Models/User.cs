using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace biancapuerta_d7_avaliacao.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }
       
        public string Password { get; set; }
    }
}
