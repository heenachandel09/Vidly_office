using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    //plain old CLR object which represents the state and behaviour of our application in terms of its problm domain
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}