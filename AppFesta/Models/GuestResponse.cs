using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFesta.Models
{
    public class GuestResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
        public string Street { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Pais { get; set; }
        public string Idade { get; set; }
        public bool? PlayGames { get; set; }
    }
}
